// Shader created with Shader Forge v1.42 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Enhanced by Antoine Guillon / Arkham Development - http://www.arkham-development.com/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.42;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:33904,y:34520,varname:node_3138,prsc:2|custl-1566-OUT;n:type:ShaderForge.SFN_Tex2d,id:3215,x:32414,y:32823,ptovrint:False,ptlb:Decal,ptin:_Decal,varname:node_3215,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:1714,x:32404,y:32629,ptovrint:False,ptlb:Background,ptin:_Background,varname:node_1714,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Lerp,id:812,x:32668,y:32743,varname:node_812,prsc:2|A-1714-RGB,B-3215-RGB,T-3215-A;n:type:ShaderForge.SFN_Relay,id:9442,x:32887,y:32743,cmnt:Decal Mask o Alpha,varname:node_9442,prsc:2|IN-812-OUT;n:type:ShaderForge.SFN_VertexColor,id:2734,x:32428,y:33039,varname:node_2734,prsc:2;n:type:ShaderForge.SFN_Tex2d,id:2642,x:32734,y:33233,ptovrint:False,ptlb:node_2642,ptin:_node_2642,varname:node_2642,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:8773,x:32698,y:32931,ptovrint:False,ptlb:node_8773,ptin:_node_8773,varname:node_8773,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Lerp,id:7504,x:32997,y:33078,varname:node_7504,prsc:2|A-8773-RGB,B-2642-RGB,T-2734-B;n:type:ShaderForge.SFN_Tex2d,id:6823,x:32316,y:34032,ptovrint:False,ptlb:RgbColor,ptin:_RgbColor,varname:node_6823,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:d97533a3ae000c74e9189e8f6a4be215,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:5678,x:32316,y:34200,varname:node_5678,prsc:2|A-6823-R,B-6823-G,C-6823-B;n:type:ShaderForge.SFN_OneMinus,id:1644,x:32316,y:33870,varname:node_1644,prsc:2|IN-6823-RGB;n:type:ShaderForge.SFN_ComponentMask,id:3593,x:32316,y:33717,varname:node_3593,prsc:2,cc1:0,cc2:1,cc3:2,cc4:-1|IN-1644-OUT;n:type:ShaderForge.SFN_Multiply,id:2062,x:32316,y:33576,varname:node_2062,prsc:2|A-3593-R,B-3593-G,C-3593-B;n:type:ShaderForge.SFN_Set,id:5900,x:32488,y:34200,varname:Mask_W,prsc:2|IN-5678-OUT;n:type:ShaderForge.SFN_Set,id:740,x:32485,y:33576,varname:Mask_K,prsc:2|IN-2062-OUT;n:type:ShaderForge.SFN_Subtract,id:6168,x:32710,y:33813,varname:node_6168,prsc:2|A-6823-RGB,B-2062-OUT;n:type:ShaderForge.SFN_Subtract,id:6913,x:32710,y:33947,varname:node_6913,prsc:2|A-6168-OUT,B-5678-OUT;n:type:ShaderForge.SFN_ComponentMask,id:1185,x:32953,y:34094,varname:node_1185,prsc:2,cc1:0,cc2:1,cc3:2,cc4:-1|IN-5612-OUT;n:type:ShaderForge.SFN_Clamp01,id:5612,x:32700,y:34094,cmnt:Saturate,varname:node_5612,prsc:2|IN-6913-OUT;n:type:ShaderForge.SFN_Multiply,id:8567,x:33240,y:34008,varname:node_8567,prsc:2|A-1185-R,B-1185-B;n:type:ShaderForge.SFN_Multiply,id:3143,x:33240,y:33832,varname:node_3143,prsc:2|A-1185-G,B-1185-B;n:type:ShaderForge.SFN_Multiply,id:3210,x:33240,y:34196,varname:node_3210,prsc:2|A-1185-G,B-1185-R;n:type:ShaderForge.SFN_Set,id:2648,x:33219,y:33776,varname:Mask_C,prsc:2|IN-3143-OUT;n:type:ShaderForge.SFN_Set,id:3288,x:33219,y:33955,varname:Mask_M,prsc:2|IN-8567-OUT;n:type:ShaderForge.SFN_Set,id:9928,x:33219,y:34149,varname:Mask_Y,prsc:2|IN-3210-OUT;n:type:ShaderForge.SFN_Add,id:1902,x:33535,y:33849,varname:node_1902,prsc:2|A-8567-OUT,B-3210-OUT;n:type:ShaderForge.SFN_Add,id:4361,x:33535,y:34035,varname:node_4361,prsc:2|A-3143-OUT,B-3210-OUT;n:type:ShaderForge.SFN_Add,id:5103,x:33535,y:34196,varname:node_5103,prsc:2|A-3143-OUT,B-8567-OUT;n:type:ShaderForge.SFN_Subtract,id:300,x:33832,y:33832,varname:node_300,prsc:2|A-1185-R,B-1902-OUT;n:type:ShaderForge.SFN_Subtract,id:8329,x:33832,y:34013,varname:node_8329,prsc:2|A-1185-G,B-4361-OUT;n:type:ShaderForge.SFN_Subtract,id:8771,x:33832,y:34176,varname:node_8771,prsc:2|A-1185-B,B-5103-OUT;n:type:ShaderForge.SFN_Set,id:8325,x:34009,y:33832,varname:Mask_R,prsc:2|IN-300-OUT;n:type:ShaderForge.SFN_Set,id:9654,x:34009,y:34176,varname:Mask_B,prsc:2|IN-8771-OUT;n:type:ShaderForge.SFN_Set,id:4426,x:34009,y:34013,varname:Mask_G,prsc:2|IN-8329-OUT;n:type:ShaderForge.SFN_Color,id:4313,x:32272,y:34597,ptovrint:False,ptlb:Color Rojo,ptin:_ColorRojo,varname:node_4313,prsc:2,glob:False,taghide:True,taghdr:True,tagprd:False,tagnsco:False,tagnrm:False,c1:7.129739,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Color,id:1357,x:32278,y:34844,ptovrint:False,ptlb:Color Verde,ptin:_ColorVerde,varname:node_1357,prsc:2,glob:False,taghide:True,taghdr:True,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:1,c3:0,c4:1;n:type:ShaderForge.SFN_Color,id:9902,x:32280,y:35087,ptovrint:False,ptlb:Color Azul,ptin:_ColorAzul,varname:node_9902,prsc:2,glob:False,taghide:True,taghdr:True,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0,c3:1,c4:1;n:type:ShaderForge.SFN_Multiply,id:2609,x:32439,y:34597,varname:node_2609,prsc:2|A-4313-RGB,B-385-OUT;n:type:ShaderForge.SFN_Multiply,id:38,x:32451,y:34844,varname:node_38,prsc:2|A-1357-RGB,B-9828-OUT;n:type:ShaderForge.SFN_Multiply,id:9292,x:32462,y:35087,varname:node_9292,prsc:2|A-9902-RGB,B-3843-OUT;n:type:ShaderForge.SFN_Get,id:385,x:32257,y:34745,varname:node_385,prsc:2|IN-8325-OUT;n:type:ShaderForge.SFN_Get,id:9828,x:32257,y:34992,varname:node_9828,prsc:2|IN-4426-OUT;n:type:ShaderForge.SFN_Get,id:3843,x:32257,y:35241,varname:node_3843,prsc:2|IN-9654-OUT;n:type:ShaderForge.SFN_SwitchProperty,id:7047,x:32880,y:34579,ptovrint:False,ptlb:IsRed,ptin:_IsRed,varname:node_7047,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-4583-RGB,B-2609-OUT;n:type:ShaderForge.SFN_Color,id:4583,x:32272,y:34407,ptovrint:False,ptlb:Color Black,ptin:_ColorBlack,varname:node_4583,prsc:2,glob:False,taghide:True,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_SwitchProperty,id:9972,x:32880,y:34791,ptovrint:False,ptlb:IsGree,ptin:_IsGree,varname:_IsRed_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-4583-RGB,B-38-OUT;n:type:ShaderForge.SFN_SwitchProperty,id:3089,x:32882,y:35048,ptovrint:False,ptlb:IsBlue,ptin:_IsBlue,varname:_IsGree_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-4583-RGB,B-9292-OUT;n:type:ShaderForge.SFN_Add,id:1566,x:33140,y:34805,varname:node_1566,prsc:2|A-7047-OUT,B-9972-OUT,C-3089-OUT;proporder:3215-1714-2642-8773-6823-4313-1357-9902-7047-4583-9972-3089;pass:END;sub:END;*/

Shader "Shader Forge/PEV_04_Masks" {
    Properties {
        _Decal ("Decal", 2D) = "white" {}
        _Background ("Background", 2D) = "white" {}
        _node_2642 ("node_2642", 2D) = "white" {}
        _node_8773 ("node_8773", 2D) = "white" {}
        _RgbColor ("RgbColor", 2D) = "white" {}
        [HideInInspector][HDR]_ColorRojo ("Color Rojo", Color) = (7.129739,0,0,1)
        [HideInInspector][HDR]_ColorVerde ("Color Verde", Color) = (0,1,0,1)
        [HideInInspector][HDR]_ColorAzul ("Color Azul", Color) = (0,0,1,1)
        [MaterialToggle] _IsRed ("IsRed", Float ) = 0
        [HideInInspector]_ColorBlack ("Color Black", Color) = (0,0,0,1)
        [MaterialToggle] _IsGree ("IsGree", Float ) = 0
        [MaterialToggle] _IsBlue ("IsBlue", Float ) = 0
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #ifndef UNITY_PASS_FORWARDBASE
            #define UNITY_PASS_FORWARDBASE
            #endif //UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal d3d11_9x xboxone ps4 psp2 n3ds wiiu switch vulkan 
            #pragma target 3.0
            uniform sampler2D _RgbColor; uniform float4 _RgbColor_ST;
            uniform float4 _ColorRojo;
            uniform float4 _ColorVerde;
            uniform float4 _ColorAzul;
            uniform fixed _IsRed;
            uniform float4 _ColorBlack;
            uniform fixed _IsGree;
            uniform fixed _IsBlue;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = UnityObjectToClipPos( v.vertex );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
////// Lighting:
                float4 _RgbColor_var = tex2D(_RgbColor,TRANSFORM_TEX(i.uv0, _RgbColor));
                float3 node_3593 = (1.0 - _RgbColor_var.rgb).rgb;
                float node_2062 = (node_3593.r*node_3593.g*node_3593.b);
                float node_5678 = (_RgbColor_var.r*_RgbColor_var.g*_RgbColor_var.b);
                float3 node_1185 = saturate(((_RgbColor_var.rgb-node_2062)-node_5678)).rgb;
                float node_8567 = (node_1185.r*node_1185.b);
                float node_3210 = (node_1185.g*node_1185.r);
                float Mask_R = (node_1185.r-(node_8567+node_3210));
                float node_3143 = (node_1185.g*node_1185.b);
                float Mask_G = (node_1185.g-(node_3143+node_3210));
                float Mask_B = (node_1185.b-(node_3143+node_8567));
                float3 finalColor = (lerp( _ColorBlack.rgb, (_ColorRojo.rgb*Mask_R), _IsRed )+lerp( _ColorBlack.rgb, (_ColorVerde.rgb*Mask_G), _IsGree )+lerp( _ColorBlack.rgb, (_ColorAzul.rgb*Mask_B), _IsBlue ));
                return fixed4(finalColor,1);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
