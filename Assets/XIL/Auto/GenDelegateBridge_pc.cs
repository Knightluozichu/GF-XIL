#if USE_HOT && UNITY_STANDALONE_WIN
namespace IL
{
    public partial class DelegateBridge
    {
        public GameFramework.GameFrameworkAction<System.Object> __Gen_Delegate_Imp1(object p0)
        {
            using (var pObjs = new Objects(p0))
            {
                GameFramework.GameFrameworkAction<System.Object> result = default(GameFramework.GameFrameworkAction<System.Object>);
                result = (GameFramework.GameFrameworkAction<System.Object>)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public GameFramework.Network.IPacketHeader __Gen_Delegate_Imp2(object p0, object p1, out System.Object p2)
        {
            p2 = default(System.Object);
            using (var pObjs = new Objects(p0, p1, new RefOutParam<System.Object>(p2)))
            {
                var param = pObjs.objs;
                GameFramework.Network.IPacketHeader result = default(GameFramework.Network.IPacketHeader);
                result = (GameFramework.Network.IPacketHeader)methodInfo.Invoke(null, param);
                p2 = ((RefOutParam<System.Object>)param[2]).value;
                return result;
            }
        }
        public GameFramework.Network.Packet __Gen_Delegate_Imp3(object p0, object p1, object p2, out System.Object p3)
        {
            p3 = default(System.Object);
            using (var pObjs = new Objects(p0, p1, p2, new RefOutParam<System.Object>(p3)))
            {
                var param = pObjs.objs;
                GameFramework.Network.Packet result = default(GameFramework.Network.Packet);
                result = (GameFramework.Network.Packet)methodInfo.Invoke(null, param);
                p3 = ((RefOutParam<System.Object>)param[3]).value;
                return result;
            }
        }
        public ProtoBuf.IExtension __Gen_Delegate_Imp4(object p0, bool p1)
        {
            using (var pObjs = new Objects(p0, p1))
            {
                ProtoBuf.IExtension result = default(ProtoBuf.IExtension);
                result = (ProtoBuf.IExtension)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public StarForce.BuildInfo __Gen_Delegate_Imp5(object p0)
        {
            using (var pObjs = new Objects(p0))
            {
                StarForce.BuildInfo result = default(StarForce.BuildInfo);
                result = (StarForce.BuildInfo)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public StarForce.BuiltinDataComponent __Gen_Delegate_Imp6()
        {
            using (var pObjs = new EmptyObjs())
            {
                StarForce.BuiltinDataComponent result = default(StarForce.BuiltinDataComponent);
                result = (StarForce.BuiltinDataComponent)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public StarForce.CampType[] __Gen_Delegate_Imp7(StarForce.CampType p0, StarForce.RelationType p1)
        {
            using (var pObjs = new Objects(p0, p1))
            {
                StarForce.CampType[] result = default(StarForce.CampType[]);
                result = (StarForce.CampType[])methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public StarForce.CampType __Gen_Delegate_Imp8(object p0)
        {
            using (var pObjs = new Objects(p0))
            {
                StarForce.CampType result = default(StarForce.CampType);
                result = (StarForce.CampType)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public StarForce.Entity __Gen_Delegate_Imp9(object p0)
        {
            using (var pObjs = new Objects(p0))
            {
                StarForce.Entity result = default(StarForce.Entity);
                result = (StarForce.Entity)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public StarForce.Entity __Gen_Delegate_Imp10(object p0, int p1)
        {
            using (var pObjs = new Objects(p0, p1))
            {
                StarForce.Entity result = default(StarForce.Entity);
                result = (StarForce.Entity)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public StarForce.GameMode __Gen_Delegate_Imp11(object p0)
        {
            using (var pObjs = new Objects(p0))
            {
                StarForce.GameMode result = default(StarForce.GameMode);
                result = (StarForce.GameMode)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public StarForce.HPBarComponent __Gen_Delegate_Imp12()
        {
            using (var pObjs = new EmptyObjs())
            {
                StarForce.HPBarComponent result = default(StarForce.HPBarComponent);
                result = (StarForce.HPBarComponent)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public StarForce.HPBarItem __Gen_Delegate_Imp13(object p0, object p1)
        {
            using (var pObjs = new Objects(p0, p1))
            {
                StarForce.HPBarItem result = default(StarForce.HPBarItem);
                result = (StarForce.HPBarItem)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public StarForce.HPBarItemObject __Gen_Delegate_Imp14(object p0)
        {
            using (var pObjs = new Objects(p0))
            {
                StarForce.HPBarItemObject result = default(StarForce.HPBarItemObject);
                result = (StarForce.HPBarItemObject)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public StarForce.ImpactData __Gen_Delegate_Imp15(object p0)
        {
            using (var pObjs = new Objects(p0))
            {
                StarForce.ImpactData result = default(StarForce.ImpactData);
                result = (StarForce.ImpactData)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public StarForce.PacketType __Gen_Delegate_Imp16(object p0)
        {
            using (var pObjs = new Objects(p0))
            {
                StarForce.PacketType result = default(StarForce.PacketType);
                result = (StarForce.PacketType)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public StarForce.RelationType __Gen_Delegate_Imp17(StarForce.CampType p0, StarForce.CampType p1)
        {
            using (var pObjs = new Objects(p0, p1))
            {
                StarForce.RelationType result = default(StarForce.RelationType);
                result = (StarForce.RelationType)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public StarForce.ScrollableBackground __Gen_Delegate_Imp18(object p0)
        {
            using (var pObjs = new Objects(p0))
            {
                StarForce.ScrollableBackground result = default(StarForce.ScrollableBackground);
                result = (StarForce.ScrollableBackground)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public StarForce.ThrusterData __Gen_Delegate_Imp19(object p0)
        {
            using (var pObjs = new Objects(p0))
            {
                StarForce.ThrusterData result = default(StarForce.ThrusterData);
                result = (StarForce.ThrusterData)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public StarForce.UGuiForm __Gen_Delegate_Imp20(object p0, StarForce.UIFormId p1, object p2)
        {
            using (var pObjs = new Objects(p0, p1, p2))
            {
                StarForce.UGuiForm result = default(StarForce.UGuiForm);
                result = (StarForce.UGuiForm)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public StarForce.UGuiForm __Gen_Delegate_Imp21(object p0, int p1, object p2)
        {
            using (var pObjs = new Objects(p0, p1, p2))
            {
                StarForce.UGuiForm result = default(StarForce.UGuiForm);
                result = (StarForce.UGuiForm)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public StarForce.UpdateResourceForm __Gen_Delegate_Imp22(object p0)
        {
            using (var pObjs = new Objects(p0))
            {
                StarForce.UpdateResourceForm result = default(StarForce.UpdateResourceForm);
                result = (StarForce.UpdateResourceForm)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public bool __Gen_Delegate_Imp23()
        {
            using (var pObjs = new EmptyObjs())
            {
                bool result = default(bool);
                result = (bool)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public bool __Gen_Delegate_Imp24(object p0)
        {
            using (var pObjs = new Objects(p0))
            {
                bool result = default(bool);
                result = (bool)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public bool __Gen_Delegate_Imp25(object p0, object p1)
        {
            using (var pObjs = new Objects(p0, p1))
            {
                bool result = default(bool);
                result = (bool)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public bool __Gen_Delegate_Imp26(object p0, StarForce.UIFormId p1, object p2)
        {
            using (var pObjs = new Objects(p0, p1, p2))
            {
                bool result = default(bool);
                result = (bool)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public bool __Gen_Delegate_Imp27(object p0, int p1, object p2)
        {
            using (var pObjs = new Objects(p0, p1, p2))
            {
                bool result = default(bool);
                result = (bool)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public bool __Gen_Delegate_Imp28(object p0, object p1, object p2)
        {
            using (var pObjs = new Objects(p0, p1, p2))
            {
                bool result = default(bool);
                result = (bool)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public bool __Gen_Delegate_Imp29(object p0, object p1, object p2, object p3)
        {
            using (var pObjs = new Objects(p0, p1, p2, p3))
            {
                bool result = default(bool);
                result = (bool)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public bool __Gen_Delegate_Imp30(object p0, System.Byte[] p1, int p2, int p3, object p4)
        {
            using (var pObjs = new Objects(p0, p1, p2, p3, p4))
            {
                bool result = default(bool);
                result = (bool)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public System.Collections.Generic.List<StarForce.ArmorData> __Gen_Delegate_Imp31(object p0)
        {
            using (var pObjs = new Objects(p0))
            {
                System.Collections.Generic.List<StarForce.ArmorData> result = default(System.Collections.Generic.List<StarForce.ArmorData>);
                result = (System.Collections.Generic.List<StarForce.ArmorData>)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public System.Collections.Generic.List<StarForce.WeaponData> __Gen_Delegate_Imp32(object p0)
        {
            using (var pObjs = new Objects(p0))
            {
                System.Collections.Generic.List<StarForce.WeaponData> result = default(System.Collections.Generic.List<StarForce.WeaponData>);
                result = (System.Collections.Generic.List<StarForce.WeaponData>)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public System.Collections.IEnumerator __Gen_Delegate_Imp33(object p0, float p1)
        {
            using (var pObjs = new Objects(p0, p1))
            {
                System.Collections.IEnumerator result = default(System.Collections.IEnumerator);
                result = (System.Collections.IEnumerator)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public System.Collections.IEnumerator __Gen_Delegate_Imp34(object p0, float p1, float p2)
        {
            using (var pObjs = new Objects(p0, p1, p2))
            {
                System.Collections.IEnumerator result = default(System.Collections.IEnumerator);
                result = (System.Collections.IEnumerator)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public System.Collections.IEnumerator __Gen_Delegate_Imp35(object p0, float p1, float p2, float p3, float p4)
        {
            using (var pObjs = new Objects(p0, p1, p2, p3, p4))
            {
                System.Collections.IEnumerator result = default(System.Collections.IEnumerator);
                result = (System.Collections.IEnumerator)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public System.DateTime __Gen_Delegate_Imp36(object p0)
        {
            using (var pObjs = new Objects(p0))
            {
                System.DateTime result = default(System.DateTime);
                result = (System.DateTime)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public int __Gen_Delegate_Imp37()
        {
            using (var pObjs = new EmptyObjs())
            {
                int result = default(int);
                result = (int)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public int __Gen_Delegate_Imp38(object p0)
        {
            using (var pObjs = new Objects(p0))
            {
                int result = default(int);
                result = (int)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public int __Gen_Delegate_Imp39(int p0, int p1)
        {
            using (var pObjs = new Objects(p0, p1))
            {
                int result = default(int);
                result = (int)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public int __Gen_Delegate_Imp40(object p0, int p1)
        {
            using (var pObjs = new Objects(p0, p1))
            {
                int result = default(int);
                result = (int)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public System.Nullable<System.Int32> __Gen_Delegate_Imp41(object p0, StarForce.UIFormId p1, object p2)
        {
            using (var pObjs = new Objects(p0, p1, p2))
            {
                System.Nullable<System.Int32> result = default(System.Nullable<System.Int32>);
                result = (System.Nullable<System.Int32>)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public System.Nullable<System.Int32> __Gen_Delegate_Imp42(object p0, int p1, object p2)
        {
            using (var pObjs = new Objects(p0, p1, p2))
            {
                System.Nullable<System.Int32> result = default(System.Nullable<System.Int32>);
                result = (System.Nullable<System.Int32>)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public System.Nullable<System.Int32> __Gen_Delegate_Imp43(object p0, int p1, object p2, object p3)
        {
            using (var pObjs = new Objects(p0, p1, p2, p3))
            {
                System.Nullable<System.Int32> result = default(System.Nullable<System.Int32>);
                result = (System.Nullable<System.Int32>)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public object __Gen_Delegate_Imp44(object p0)
        {
            using (var pObjs = new Objects(p0))
            {
                object result = default(object);
                result = (object)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public object __Gen_Delegate_Imp45(object p0, object p1, object p2)
        {
            using (var pObjs = new Objects(p0, p1, p2))
            {
                object result = default(object);
                result = (object)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public float __Gen_Delegate_Imp46(object p0)
        {
            using (var pObjs = new Objects(p0))
            {
                float result = default(float);
                result = (float)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public float __Gen_Delegate_Imp47(object p0, object p1)
        {
            using (var pObjs = new Objects(p0, p1))
            {
                float result = default(float);
                result = (float)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public string __Gen_Delegate_Imp48(object p0)
        {
            using (var pObjs = new Objects(p0))
            {
                string result = default(string);
                result = (string)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public string __Gen_Delegate_Imp49(object p0, bool p1)
        {
            using (var pObjs = new Objects(p0, p1))
            {
                string result = default(string);
                result = (string)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public string __Gen_Delegate_Imp50(object p0, long p1)
        {
            using (var pObjs = new Objects(p0, p1))
            {
                string result = default(string);
                result = (string)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public string __Gen_Delegate_Imp51(object p0, object p1)
        {
            using (var pObjs = new Objects(p0, p1))
            {
                string result = default(string);
                result = (string)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public System.Type __Gen_Delegate_Imp52(object p0, int p1)
        {
            using (var pObjs = new Objects(p0, p1))
            {
                System.Type result = default(System.Type);
                result = (System.Type)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public void __Gen_Delegate_Imp53()
        {
            using (var pObjs = new EmptyObjs())
            {
                methodInfo.Invoke(null, pObjs.objs);
            }
        }
        public void __Gen_Delegate_Imp54(int p0, int p1, int p2, int p3, object p4, object p5, object p6, object p7, UnityEngine.Vector3 p8, UnityEngine.Vector2 p9, UnityEngine.Vector4 p10)
        {
            using (var pObjs = new Objects(p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10))
            {
                methodInfo.Invoke(null, pObjs.objs);
            }
        }
        public void __Gen_Delegate_Imp55(object p0)
        {
            using (var pObjs = new Objects(p0))
            {
                methodInfo.Invoke(null, pObjs.objs);
            }
        }
        public void __Gen_Delegate_Imp56(object p0, bool p1)
        {
            using (var pObjs = new Objects(p0, p1))
            {
                methodInfo.Invoke(null, pObjs.objs);
            }
        }
        public void __Gen_Delegate_Imp57(object p0, int p1)
        {
            using (var pObjs = new Objects(p0, p1))
            {
                methodInfo.Invoke(null, pObjs.objs);
            }
        }
        public void __Gen_Delegate_Imp58(object p0, System.Object[] p1)
        {
            using (var pObjs = new Objects(p0, p1))
            {
                methodInfo.Invoke(null, pObjs.objs);
            }
        }
        public void __Gen_Delegate_Imp59(object p0, object p1)
        {
            using (var pObjs = new Objects(p0, p1))
            {
                methodInfo.Invoke(null, pObjs.objs);
            }
        }
        public void __Gen_Delegate_Imp60(object p0, float p1)
        {
            using (var pObjs = new Objects(p0, p1))
            {
                methodInfo.Invoke(null, pObjs.objs);
            }
        }
        public void __Gen_Delegate_Imp61(object p0, UnityEngine.Quaternion p1)
        {
            using (var pObjs = new Objects(p0, p1))
            {
                methodInfo.Invoke(null, pObjs.objs);
            }
        }
        public void __Gen_Delegate_Imp62(object p0, UnityEngine.Vector3 p1)
        {
            using (var pObjs = new Objects(p0, p1))
            {
                methodInfo.Invoke(null, pObjs.objs);
            }
        }
        public void __Gen_Delegate_Imp63(object p0, bool p1, object p2)
        {
            using (var pObjs = new Objects(p0, p1, p2))
            {
                methodInfo.Invoke(null, pObjs.objs);
            }
        }
        public void __Gen_Delegate_Imp64(object p0, ref System.Int32 p1, out System.Int32 p2)
        {
            p2 = default(System.Int32);
            using (var pObjs = new Objects(p0, new RefOutParam<System.Int32>(p1), new RefOutParam<System.Int32>(p2)))
            {
                var param = pObjs.objs;
                methodInfo.Invoke(null, param);
                p1 = ((RefOutParam<System.Int32>)param[1]).value;
                p2 = ((RefOutParam<System.Int32>)param[2]).value;
            }
        }
        public void __Gen_Delegate_Imp65(object p0, int p1, int p2)
        {
            using (var pObjs = new Objects(p0, p1, p2))
            {
                methodInfo.Invoke(null, pObjs.objs);
            }
        }
        public void __Gen_Delegate_Imp66(object p0, int p1, long p2)
        {
            using (var pObjs = new Objects(p0, p1, p2))
            {
                methodInfo.Invoke(null, pObjs.objs);
            }
        }
        public void __Gen_Delegate_Imp67(object p0, int p1, object p2)
        {
            using (var pObjs = new Objects(p0, p1, p2))
            {
                methodInfo.Invoke(null, pObjs.objs);
            }
        }
        public void __Gen_Delegate_Imp68(object p0, object p1, bool p2)
        {
            using (var pObjs = new Objects(p0, p1, p2))
            {
                methodInfo.Invoke(null, pObjs.objs);
            }
        }
        public void __Gen_Delegate_Imp69(object p0, object p1, int p2)
        {
            using (var pObjs = new Objects(p0, p1, p2))
            {
                methodInfo.Invoke(null, pObjs.objs);
            }
        }
        public void __Gen_Delegate_Imp70(object p0, object p1, object p2)
        {
            using (var pObjs = new Objects(p0, p1, p2))
            {
                methodInfo.Invoke(null, pObjs.objs);
            }
        }
        public void __Gen_Delegate_Imp71(object p0, object p1, float p2)
        {
            using (var pObjs = new Objects(p0, p1, p2))
            {
                methodInfo.Invoke(null, pObjs.objs);
            }
        }
        public void __Gen_Delegate_Imp72(object p0, float p1, object p2)
        {
            using (var pObjs = new Objects(p0, p1, p2))
            {
                methodInfo.Invoke(null, pObjs.objs);
            }
        }
        public void __Gen_Delegate_Imp73(object p0, float p1, float p2)
        {
            using (var pObjs = new Objects(p0, p1, p2))
            {
                methodInfo.Invoke(null, pObjs.objs);
            }
        }
        public void __Gen_Delegate_Imp74(object p0, int p1, int p2, StarForce.CampType p3)
        {
            using (var pObjs = new Objects(p0, p1, p2, p3))
            {
                methodInfo.Invoke(null, pObjs.objs);
            }
        }
        public void __Gen_Delegate_Imp75(object p0, object p1, object p2, object p3)
        {
            using (var pObjs = new Objects(p0, p1, p2, p3))
            {
                methodInfo.Invoke(null, pObjs.objs);
            }
        }
        public void __Gen_Delegate_Imp76(object p0, object p1, float p2, float p3)
        {
            using (var pObjs = new Objects(p0, p1, p2, p3))
            {
                methodInfo.Invoke(null, pObjs.objs);
            }
        }
        public void __Gen_Delegate_Imp77(object p0, int p1, int p2, int p3, StarForce.CampType p4)
        {
            using (var pObjs = new Objects(p0, p1, p2, p3, p4))
            {
                methodInfo.Invoke(null, pObjs.objs);
            }
        }
        public void __Gen_Delegate_Imp78(object p0, object p1, int p2, object p3, object p4)
        {
            using (var pObjs = new Objects(p0, p1, p2, p3, p4))
            {
                methodInfo.Invoke(null, pObjs.objs);
            }
        }
        public void __Gen_Delegate_Imp79(object p0, object p1, object p2, int p3, object p4)
        {
            using (var pObjs = new Objects(p0, p1, p2, p3, p4))
            {
                methodInfo.Invoke(null, pObjs.objs);
            }
        }
        public void __Gen_Delegate_Imp80(object p0, object p1, object p2, float p3, float p4)
        {
            using (var pObjs = new Objects(p0, p1, p2, p3, p4))
            {
                methodInfo.Invoke(null, pObjs.objs);
            }
        }
        public void __Gen_Delegate_Imp81(object p0, int p1, int p2, int p3, long p4, long p5)
        {
            using (var pObjs = new Objects(p0, p1, p2, p3, p4, p5))
            {
                methodInfo.Invoke(null, pObjs.objs);
            }
        }
        public void __Gen_Delegate_Imp82(object p0, int p1, int p2, int p3, StarForce.CampType p4, int p5, float p6)
        {
            using (var pObjs = new Objects(p0, p1, p2, p3, p4, p5, p6))
            {
                methodInfo.Invoke(null, pObjs.objs);
            }
        }
        public UnityEngine.Animation __Gen_Delegate_Imp83(object p0)
        {
            using (var pObjs = new Objects(p0))
            {
                UnityEngine.Animation result = default(UnityEngine.Animation);
                result = (UnityEngine.Animation)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public UnityEngine.BoxCollider __Gen_Delegate_Imp84(object p0)
        {
            using (var pObjs = new Objects(p0))
            {
                UnityEngine.BoxCollider result = default(UnityEngine.BoxCollider);
                result = (UnityEngine.BoxCollider)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public UnityEngine.Color32 __Gen_Delegate_Imp85(object p0)
        {
            using (var pObjs = new Objects(p0))
            {
                UnityEngine.Color32 result = default(UnityEngine.Color32);
                result = (UnityEngine.Color32)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public UnityEngine.Color __Gen_Delegate_Imp86(object p0)
        {
            using (var pObjs = new Objects(p0))
            {
                UnityEngine.Color result = default(UnityEngine.Color);
                result = (UnityEngine.Color)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public UnityEngine.Quaternion __Gen_Delegate_Imp87(object p0)
        {
            using (var pObjs = new Objects(p0))
            {
                UnityEngine.Quaternion result = default(UnityEngine.Quaternion);
                result = (UnityEngine.Quaternion)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public UnityEngine.Rect __Gen_Delegate_Imp88(object p0)
        {
            using (var pObjs = new Objects(p0))
            {
                UnityEngine.Rect result = default(UnityEngine.Rect);
                result = (UnityEngine.Rect)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public UnityEngine.Vector2 __Gen_Delegate_Imp89(object p0)
        {
            using (var pObjs = new Objects(p0))
            {
                UnityEngine.Vector2 result = default(UnityEngine.Vector2);
                result = (UnityEngine.Vector2)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public UnityEngine.Vector3 __Gen_Delegate_Imp90(object p0)
        {
            using (var pObjs = new Objects(p0))
            {
                UnityEngine.Vector3 result = default(UnityEngine.Vector3);
                result = (UnityEngine.Vector3)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public UnityEngine.Vector4 __Gen_Delegate_Imp91(object p0)
        {
            using (var pObjs = new Objects(p0))
            {
                UnityEngine.Vector4 result = default(UnityEngine.Vector4);
                result = (UnityEngine.Vector4)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public UnityGameFramework.Runtime.BaseComponent __Gen_Delegate_Imp92()
        {
            using (var pObjs = new EmptyObjs())
            {
                UnityGameFramework.Runtime.BaseComponent result = default(UnityGameFramework.Runtime.BaseComponent);
                result = (UnityGameFramework.Runtime.BaseComponent)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public UnityGameFramework.Runtime.ConfigComponent __Gen_Delegate_Imp93()
        {
            using (var pObjs = new EmptyObjs())
            {
                UnityGameFramework.Runtime.ConfigComponent result = default(UnityGameFramework.Runtime.ConfigComponent);
                result = (UnityGameFramework.Runtime.ConfigComponent)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public UnityGameFramework.Runtime.DataNodeComponent __Gen_Delegate_Imp94()
        {
            using (var pObjs = new EmptyObjs())
            {
                UnityGameFramework.Runtime.DataNodeComponent result = default(UnityGameFramework.Runtime.DataNodeComponent);
                result = (UnityGameFramework.Runtime.DataNodeComponent)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public UnityGameFramework.Runtime.DataTableComponent __Gen_Delegate_Imp95()
        {
            using (var pObjs = new EmptyObjs())
            {
                UnityGameFramework.Runtime.DataTableComponent result = default(UnityGameFramework.Runtime.DataTableComponent);
                result = (UnityGameFramework.Runtime.DataTableComponent)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public UnityGameFramework.Runtime.DebuggerComponent __Gen_Delegate_Imp96()
        {
            using (var pObjs = new EmptyObjs())
            {
                UnityGameFramework.Runtime.DebuggerComponent result = default(UnityGameFramework.Runtime.DebuggerComponent);
                result = (UnityGameFramework.Runtime.DebuggerComponent)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public UnityGameFramework.Runtime.DownloadComponent __Gen_Delegate_Imp97()
        {
            using (var pObjs = new EmptyObjs())
            {
                UnityGameFramework.Runtime.DownloadComponent result = default(UnityGameFramework.Runtime.DownloadComponent);
                result = (UnityGameFramework.Runtime.DownloadComponent)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public UnityGameFramework.Runtime.EntityComponent __Gen_Delegate_Imp98()
        {
            using (var pObjs = new EmptyObjs())
            {
                UnityGameFramework.Runtime.EntityComponent result = default(UnityGameFramework.Runtime.EntityComponent);
                result = (UnityGameFramework.Runtime.EntityComponent)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public UnityGameFramework.Runtime.EventComponent __Gen_Delegate_Imp99()
        {
            using (var pObjs = new EmptyObjs())
            {
                UnityGameFramework.Runtime.EventComponent result = default(UnityGameFramework.Runtime.EventComponent);
                result = (UnityGameFramework.Runtime.EventComponent)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public UnityGameFramework.Runtime.FileSystemComponent __Gen_Delegate_Imp100()
        {
            using (var pObjs = new EmptyObjs())
            {
                UnityGameFramework.Runtime.FileSystemComponent result = default(UnityGameFramework.Runtime.FileSystemComponent);
                result = (UnityGameFramework.Runtime.FileSystemComponent)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public UnityGameFramework.Runtime.FsmComponent __Gen_Delegate_Imp101()
        {
            using (var pObjs = new EmptyObjs())
            {
                UnityGameFramework.Runtime.FsmComponent result = default(UnityGameFramework.Runtime.FsmComponent);
                result = (UnityGameFramework.Runtime.FsmComponent)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public UnityGameFramework.Runtime.LocalizationComponent __Gen_Delegate_Imp102()
        {
            using (var pObjs = new EmptyObjs())
            {
                UnityGameFramework.Runtime.LocalizationComponent result = default(UnityGameFramework.Runtime.LocalizationComponent);
                result = (UnityGameFramework.Runtime.LocalizationComponent)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public UnityGameFramework.Runtime.NetworkComponent __Gen_Delegate_Imp103()
        {
            using (var pObjs = new EmptyObjs())
            {
                UnityGameFramework.Runtime.NetworkComponent result = default(UnityGameFramework.Runtime.NetworkComponent);
                result = (UnityGameFramework.Runtime.NetworkComponent)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public UnityGameFramework.Runtime.ObjectPoolComponent __Gen_Delegate_Imp104()
        {
            using (var pObjs = new EmptyObjs())
            {
                UnityGameFramework.Runtime.ObjectPoolComponent result = default(UnityGameFramework.Runtime.ObjectPoolComponent);
                result = (UnityGameFramework.Runtime.ObjectPoolComponent)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public UnityGameFramework.Runtime.ProcedureComponent __Gen_Delegate_Imp105()
        {
            using (var pObjs = new EmptyObjs())
            {
                UnityGameFramework.Runtime.ProcedureComponent result = default(UnityGameFramework.Runtime.ProcedureComponent);
                result = (UnityGameFramework.Runtime.ProcedureComponent)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public UnityGameFramework.Runtime.ResourceComponent __Gen_Delegate_Imp106()
        {
            using (var pObjs = new EmptyObjs())
            {
                UnityGameFramework.Runtime.ResourceComponent result = default(UnityGameFramework.Runtime.ResourceComponent);
                result = (UnityGameFramework.Runtime.ResourceComponent)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public UnityGameFramework.Runtime.SceneComponent __Gen_Delegate_Imp107()
        {
            using (var pObjs = new EmptyObjs())
            {
                UnityGameFramework.Runtime.SceneComponent result = default(UnityGameFramework.Runtime.SceneComponent);
                result = (UnityGameFramework.Runtime.SceneComponent)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public UnityGameFramework.Runtime.SettingComponent __Gen_Delegate_Imp108()
        {
            using (var pObjs = new EmptyObjs())
            {
                UnityGameFramework.Runtime.SettingComponent result = default(UnityGameFramework.Runtime.SettingComponent);
                result = (UnityGameFramework.Runtime.SettingComponent)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public UnityGameFramework.Runtime.SoundComponent __Gen_Delegate_Imp109()
        {
            using (var pObjs = new EmptyObjs())
            {
                UnityGameFramework.Runtime.SoundComponent result = default(UnityGameFramework.Runtime.SoundComponent);
                result = (UnityGameFramework.Runtime.SoundComponent)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public UnityGameFramework.Runtime.UIComponent __Gen_Delegate_Imp110()
        {
            using (var pObjs = new EmptyObjs())
            {
                UnityGameFramework.Runtime.UIComponent result = default(UnityGameFramework.Runtime.UIComponent);
                result = (UnityGameFramework.Runtime.UIComponent)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }
        public UnityGameFramework.Runtime.WebRequestComponent __Gen_Delegate_Imp111()
        {
            using (var pObjs = new EmptyObjs())
            {
                UnityGameFramework.Runtime.WebRequestComponent result = default(UnityGameFramework.Runtime.WebRequestComponent);
                result = (UnityGameFramework.Runtime.WebRequestComponent)methodInfo.Invoke(null, pObjs.objs);
                return result;
            }
        }

    }
}
#endif