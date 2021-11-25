namespace wxb
{
    using System.IO;

    public interface IResLoad
    {
        Stream GetStream(string path);
    }

#if UNITY_EDITOR
    // 编辑器下的资源加载
    class EditorResLoad : IResLoad
    {
        public EditorResLoad()
        {
            RootPath = ResourcesPath.dataPath + "/../";
        }

        byte[] dll { get; set; }
        public EditorResLoad(byte[] dll)
        {
            this.dll = dll;
        }

        public Stream GetStream()
        {
            return new MemoryStream(dll);
        }

        string RootPath { get; set; }

        Stream IResLoad.GetStream(string path)
        {
            string filepath = RootPath + path;
            if (!File.Exists(filepath))
            {
                return null;
            }

            try
            {
                return new MemoryStream(File.ReadAllBytes(filepath));
            }
            catch (System.Exception ex)
            {
                wxb.L.LogException(ex);
            }

            return null;
        }
    }


#endif


    class EditorResLoadRuntime : IResLoad
    {
        public EditorResLoadRuntime()
        {
            RootPath = ResourcesPath.dataPath + "/../";
        }

        byte[] dll { get; set; }
        public EditorResLoadRuntime(byte[] dll)
        {
            this.dll = dll;
        }

        public Stream GetStream()
        {
            return new MemoryStream(dll);
        }

        string RootPath { get; set; }

        Stream IResLoad.GetStream(string path)
        {
            string filepath = RootPath + path;
            if (!File.Exists(filepath))
            {
                return null;
            }

            try
            {
                return new MemoryStream(File.ReadAllBytes(filepath));
            }
            catch (System.Exception ex)
            {
                wxb.L.LogException(ex);
            }

            return null;
        }
    }



    public static class ResLoad
    {
        static IResLoad current = null;

        public static void Set(IResLoad load)
        {
            current = load;
        }

        /// <summary>
        /// 编辑器模式下，原dll热更测试
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static Stream GetStream(string path)
        {
            return current.GetStream(path);
        }


        /// <summary>
        /// 编辑器模式下，GF dll热更测试
        /// </summary>
        /// <returns></returns>
        public static Stream GetStream()
        {
            return ((EditorResLoadRuntime)current).GetStream();
        }
    }

}