using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;

namespace ILRuntime.Runtime.Generated
{
    unsafe class FairyGUI_GGroup_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(FairyGUI.GGroup);
            args = new Type[]{};
            method = type.GetMethod("get_layout", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_layout_0);
            args = new Type[]{typeof(FairyGUI.GroupLayoutType)};
            method = type.GetMethod("set_layout", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_layout_1);
            args = new Type[]{};
            method = type.GetMethod("get_lineGap", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_lineGap_2);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_lineGap", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_lineGap_3);
            args = new Type[]{};
            method = type.GetMethod("get_columnGap", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_columnGap_4);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_columnGap", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_columnGap_5);
            args = new Type[]{};
            method = type.GetMethod("get_excludeInvisibles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_excludeInvisibles_6);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_excludeInvisibles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_excludeInvisibles_7);
            args = new Type[]{};
            method = type.GetMethod("get_autoSizeDisabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_autoSizeDisabled_8);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_autoSizeDisabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_autoSizeDisabled_9);
            args = new Type[]{};
            method = type.GetMethod("get_mainGridMinSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_mainGridMinSize_10);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_mainGridMinSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_mainGridMinSize_11);
            args = new Type[]{};
            method = type.GetMethod("get_mainGridIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_mainGridIndex_12);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_mainGridIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_mainGridIndex_13);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("SetBoundsChangedFlag", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetBoundsChangedFlag_14);
            args = new Type[]{};
            method = type.GetMethod("EnsureBoundsCorrect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, EnsureBoundsCorrect_15);
            args = new Type[]{typeof(FairyGUI.Utils.ByteBuffer), typeof(System.Int32)};
            method = type.GetMethod("Setup_BeforeAdd", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Setup_BeforeAdd_16);
            args = new Type[]{typeof(FairyGUI.Utils.ByteBuffer), typeof(System.Int32)};
            method = type.GetMethod("Setup_AfterAdd", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Setup_AfterAdd_17);



            app.RegisterCLRCreateDefaultInstance(type, () => new FairyGUI.GGroup());
            app.RegisterCLRCreateArrayInstance(type, s => new FairyGUI.GGroup[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_layout_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.GGroup instance_of_this_method = (FairyGUI.GGroup)typeof(FairyGUI.GGroup).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.layout;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_layout_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.GroupLayoutType @value = (FairyGUI.GroupLayoutType)typeof(FairyGUI.GroupLayoutType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.GGroup instance_of_this_method = (FairyGUI.GGroup)typeof(FairyGUI.GGroup).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.layout = value;

            return __ret;
        }

        static StackObject* get_lineGap_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.GGroup instance_of_this_method = (FairyGUI.GGroup)typeof(FairyGUI.GGroup).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.lineGap;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_lineGap_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.GGroup instance_of_this_method = (FairyGUI.GGroup)typeof(FairyGUI.GGroup).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.lineGap = value;

            return __ret;
        }

        static StackObject* get_columnGap_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.GGroup instance_of_this_method = (FairyGUI.GGroup)typeof(FairyGUI.GGroup).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.columnGap;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_columnGap_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.GGroup instance_of_this_method = (FairyGUI.GGroup)typeof(FairyGUI.GGroup).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.columnGap = value;

            return __ret;
        }

        static StackObject* get_excludeInvisibles_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.GGroup instance_of_this_method = (FairyGUI.GGroup)typeof(FairyGUI.GGroup).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.excludeInvisibles;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_excludeInvisibles_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.GGroup instance_of_this_method = (FairyGUI.GGroup)typeof(FairyGUI.GGroup).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.excludeInvisibles = value;

            return __ret;
        }

        static StackObject* get_autoSizeDisabled_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.GGroup instance_of_this_method = (FairyGUI.GGroup)typeof(FairyGUI.GGroup).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.autoSizeDisabled;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_autoSizeDisabled_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.GGroup instance_of_this_method = (FairyGUI.GGroup)typeof(FairyGUI.GGroup).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.autoSizeDisabled = value;

            return __ret;
        }

        static StackObject* get_mainGridMinSize_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.GGroup instance_of_this_method = (FairyGUI.GGroup)typeof(FairyGUI.GGroup).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.mainGridMinSize;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_mainGridMinSize_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.GGroup instance_of_this_method = (FairyGUI.GGroup)typeof(FairyGUI.GGroup).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.mainGridMinSize = value;

            return __ret;
        }

        static StackObject* get_mainGridIndex_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.GGroup instance_of_this_method = (FairyGUI.GGroup)typeof(FairyGUI.GGroup).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.mainGridIndex;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_mainGridIndex_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.GGroup instance_of_this_method = (FairyGUI.GGroup)typeof(FairyGUI.GGroup).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.mainGridIndex = value;

            return __ret;
        }

        static StackObject* SetBoundsChangedFlag_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @positionChangedOnly = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.GGroup instance_of_this_method = (FairyGUI.GGroup)typeof(FairyGUI.GGroup).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetBoundsChangedFlag(@positionChangedOnly);

            return __ret;
        }

        static StackObject* EnsureBoundsCorrect_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.GGroup instance_of_this_method = (FairyGUI.GGroup)typeof(FairyGUI.GGroup).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.EnsureBoundsCorrect();

            return __ret;
        }

        static StackObject* Setup_BeforeAdd_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @beginPos = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.Utils.ByteBuffer @buffer = (FairyGUI.Utils.ByteBuffer)typeof(FairyGUI.Utils.ByteBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            FairyGUI.GGroup instance_of_this_method = (FairyGUI.GGroup)typeof(FairyGUI.GGroup).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Setup_BeforeAdd(@buffer, @beginPos);

            return __ret;
        }

        static StackObject* Setup_AfterAdd_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @beginPos = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.Utils.ByteBuffer @buffer = (FairyGUI.Utils.ByteBuffer)typeof(FairyGUI.Utils.ByteBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            FairyGUI.GGroup instance_of_this_method = (FairyGUI.GGroup)typeof(FairyGUI.GGroup).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Setup_AfterAdd(@buffer, @beginPos);

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new FairyGUI.GGroup();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
