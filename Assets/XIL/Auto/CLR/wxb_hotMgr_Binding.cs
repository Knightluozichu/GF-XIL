#if USE_HOT
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Linq;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;

namespace ILRuntime.Runtime.Generated
{
    unsafe class wxb_hotMgr_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(wxb.hotMgr);
            args = new Type[]{};
            method = type.GetMethod("get_appdomain", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_appdomain_0);
            args = new Type[]{};
            method = type.GetMethod("get_RefType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_RefType_1);
            args = new Type[]{};
            method = type.GetMethod("get_AllTypes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_AllTypes_2);
            args = new Type[]{};
            method = type.GetMethod("get_DLL", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_DLL_3);
            args = new Type[]{typeof(System.Byte[])};
            method = type.GetMethod("set_DLL", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_DLL_4);
            args = new Type[]{typeof(wxb.IResLoad)};
            method = type.GetMethod("Init", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Init_5);
            args = new Type[]{typeof(System.IO.Stream)};
            method = type.GetMethod("CopyStream", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CopyStream_6);
            args = new Type[]{};
            method = type.GetMethod("InitHotModule", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, InitHotModule_7);
            args = new Type[]{typeof(ILRuntime.Runtime.Enviorment.AppDomain)};
            method = type.GetMethod("RegDelegate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegDelegate_8);
            args = new Type[]{typeof(System.Type), typeof(System.String), typeof(System.Reflection.MethodInfo)};
            method = type.GetMethod("ReplaceField", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReplaceField_9);
            args = new Type[]{typeof(System.Reflection.MethodInfo)};
            method = type.GetMethod("IsStatic", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsStatic_10);
            args = new Type[]{typeof(System.Type), typeof(System.String), typeof(System.Reflection.MethodInfo)};
            method = type.GetMethod("ReplaceFunc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReplaceFunc_11);
            args = new Type[]{typeof(System.Type), typeof(System.Action<System.Type>)};
            method = type.GetMethod("FindAttribute", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FindAttribute_12);
            args = new Type[]{};
            method = type.GetMethod("ReleaseAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReleaseAll_13);

            field = type.GetField("isGF", flag);
            app.RegisterCLRFieldGetter(field, get_isGF_0);
            app.RegisterCLRFieldSetter(field, set_isGF_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_isGF_0, AssignFromStack_isGF_0);
            field = type.GetField("bindingFlags", flag);
            app.RegisterCLRFieldGetter(field, get_bindingFlags_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_bindingFlags_1, null);




        }


        static StackObject* get_appdomain_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = wxb.hotMgr.appdomain;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_RefType_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = wxb.hotMgr.RefType;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_AllTypes_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = wxb.hotMgr.AllTypes;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_DLL_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = wxb.hotMgr.DLL;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_DLL_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Byte[] @value = (System.Byte[])typeof(System.Byte[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            wxb.hotMgr.DLL = value;

            return __ret;
        }

        static StackObject* Init_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            wxb.IResLoad @resLoad = (wxb.IResLoad)typeof(wxb.IResLoad).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            wxb.hotMgr.Init(@resLoad);

            return __ret;
        }

        static StackObject* CopyStream_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.IO.Stream @input = (System.IO.Stream)typeof(System.IO.Stream).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = wxb.hotMgr.CopyStream(@input);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* InitHotModule_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            wxb.hotMgr.InitHotModule();

            return __ret;
        }

        static StackObject* RegDelegate_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ILRuntime.Runtime.Enviorment.AppDomain @appdomain = (ILRuntime.Runtime.Enviorment.AppDomain)typeof(ILRuntime.Runtime.Enviorment.AppDomain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            wxb.hotMgr.RegDelegate(@appdomain);

            return __ret;
        }

        static StackObject* ReplaceField_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Reflection.MethodInfo @info = (System.Reflection.MethodInfo)typeof(System.Reflection.MethodInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @fieldName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Type @type = (System.Type)typeof(System.Type).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = wxb.hotMgr.ReplaceField(@type, @fieldName, @info);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsStatic_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Reflection.MethodInfo @info = (System.Reflection.MethodInfo)typeof(System.Reflection.MethodInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = wxb.hotMgr.IsStatic(@info);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* ReplaceFunc_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Reflection.MethodInfo @info = (System.Reflection.MethodInfo)typeof(System.Reflection.MethodInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Type @type = (System.Type)typeof(System.Type).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = wxb.hotMgr.ReplaceFunc(@type, @name, @info);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* FindAttribute_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Type> @on = (System.Action<System.Type>)typeof(System.Action<System.Type>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Type @attType = (System.Type)typeof(System.Type).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            wxb.hotMgr.FindAttribute(@attType, @on);

            return __ret;
        }

        static StackObject* ReleaseAll_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            wxb.hotMgr.ReleaseAll();

            return __ret;
        }


        static object get_isGF_0(ref object o)
        {
            return wxb.hotMgr.isGF;
        }

        static StackObject* CopyToStack_isGF_0(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = wxb.hotMgr.isGF;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_isGF_0(ref object o, object v)
        {
            wxb.hotMgr.isGF = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_isGF_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @isGF = ptr_of_this_method->Value == 1;
            wxb.hotMgr.isGF = @isGF;
            return ptr_of_this_method;
        }

        static object get_bindingFlags_1(ref object o)
        {
            return wxb.hotMgr.bindingFlags;
        }

        static StackObject* CopyToStack_bindingFlags_1(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = wxb.hotMgr.bindingFlags;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }




    }
}
#endif
