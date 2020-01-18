// Shader created with Shader Forge v1.42 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Enhanced by Antoine Guillon / Arkham Development - http://www.arkham-development.com/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.42;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:33358,y:32918,varname:node_3138,prsc:2|custl-7369-OUT;n:type:ShaderForge.SFN_NormalVector,id:5456,x:32138,y:32932,prsc:2,pt:False;n:type:ShaderForge.SFN_Abs,id:6308,x:32308,y:32932,varname:node_6308,prsc:2|IN-5456-OUT;n:type:ShaderForge.SFN_ChannelBlend,id:7662,x:32516,y:32932,varname:node_7662,prsc:2,chbt:0|M-6308-OUT,R-3165-RGB,G-6622-RGB,B-424-RGB;n:type:ShaderForge.SFN_Color,id:6622,x:32138,y:33298,ptovrint:False,ptlb:Color_Top,ptin:_Color_Top,varname:node_6622,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0.5,c3:0.3,c4:1;n:type:ShaderForge.SFN_Color,id:3165,x:32138,y:33129,ptovrint:False,ptlb:Color_Sides,ptin:_Color_Sides,varname:node_3165,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0.5,c3:0.4,c4:1;n:type:ShaderForge.SFN_Color,id:424,x:32138,y:33466,ptovrint:False,ptlb:Color_Front,ptin:_Color_Front,varname:node_424,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.8,c2:0.2,c3:0.2,c4:1;n:type:ShaderForge.SFN_Color,id:6991,x:32138,y:33668,ptovrint:False,ptlb:Color_Fog,ptin:_Color_Fog,varname:node_6991,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.7,c2:0.8,c3:0.7,c4:1;n:type:ShaderForge.SFN_FragmentPosition,id:6935,x:32138,y:33831,cmnt:VertexPosition,varname:node_6935,prsc:2;n:type:ShaderForge.SFN_RemapRangeAdvanced,id:4474,x:32384,y:33873,varname:node_4474,prsc:2|IN-6935-Y,IMIN-342-OUT,IMAX-8311-OUT,OMIN-5579-OUT,OMAX-5716-OUT;n:type:ShaderForge.SFN_Vector1,id:5579,x:32138,y:34151,varname:node_5579,prsc:2,v1:0;n:type:ShaderForge.SFN_Vector1,id:5716,x:32138,y:34220,varname:node_5716,prsc:2,v1:1;n:type:ShaderForge.SFN_ValueProperty,id:342,x:32138,y:33986,ptovrint:False,ptlb:Bottom,ptin:_Bottom,varname:node_342,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:-0.5;n:type:ShaderForge.SFN_ValueProperty,id:8311,x:32138,y:34063,ptovrint:False,ptlb:Height,ptin:_Height,varname:_node_342_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5;n:type:ShaderForge.SFN_Clamp01,id:2893,x:32556,y:33873,varname:node_2893,prsc:2|IN-4474-OUT;n:type:ShaderForge.SFN_ValueProperty,id:1,x:32138,y:34331,ptovrint:False,ptlb:Center,ptin:_Center,varname:node_1,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:7041,x:32138,y:34506,ptovrint:False,ptlb:Width,ptin:_Width,varname:_Center_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Vector1,id:9247,x:32138,y:34404,varname:node_9247,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Multiply,id:2422,x:32340,y:34462,varname:node_2422,prsc:2|A-9247-OUT,B-7041-OUT;n:type:ShaderForge.SFN_Add,id:3604,x:32560,y:34287,varname:node_3604,prsc:2|A-1-OUT,B-2422-OUT;n:type:ShaderForge.SFN_Subtract,id:8913,x:32560,y:34462,varname:node_8913,prsc:2|A-1-OUT,B-2422-OUT;n:type:ShaderForge.SFN_Set,id:9372,x:32722,y:34287,cmnt:Opc2 del Fog Remap,varname:Max_Remap,prsc:2|IN-3604-OUT;n:type:ShaderForge.SFN_Set,id:8762,x:32722,y:34462,varname:Min_Remap,prsc:2|IN-8913-OUT;n:type:ShaderForge.SFN_Set,id:3700,x:32283,y:33668,varname:Fog,prsc:2|IN-6991-RGB;n:type:ShaderForge.SFN_Set,id:3844,x:32705,y:33873,varname:Height_Gradient,prsc:2|IN-2893-OUT;n:type:ShaderForge.SFN_Set,id:2048,x:32878,y:32733,varname:Diffuse_Color,prsc:2|IN-3799-OUT;n:type:ShaderForge.SFN_Lerp,id:7369,x:33096,y:33160,varname:node_7369,prsc:2|A-1426-OUT,B-7462-OUT,T-4933-OUT;n:type:ShaderForge.SFN_Get,id:1426,x:32875,y:33141,varname:node_1426,prsc:2|IN-3700-OUT;n:type:ShaderForge.SFN_Get,id:7462,x:32875,y:33196,varname:node_7462,prsc:2|IN-2048-OUT;n:type:ShaderForge.SFN_Get,id:4933,x:32875,y:33249,varname:node_4933,prsc:2|IN-3844-OUT;n:type:ShaderForge.SFN_FaceSign,id:765,x:32489,y:32792,varname:node_765,prsc:2,fstp:0;n:type:ShaderForge.SFN_Lerp,id:3799,x:32702,y:32733,varname:node_3799,prsc:2|A-1381-RGB,B-7662-OUT,T-765-VFACE;n:type:ShaderForge.SFN_Color,id:1381,x:32489,y:32643,ptovrint:False,ptlb:Color_Inside,ptin:_Color_Inside,varname:node_1381,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.6,c2:0.1,c3:0,c4:1;proporder:3165-6622-424-342-8311-6991-1381;pass:END;sub:END;*/

Shader "Shader Forge/PEV_06_MonumentValley" {
    Properties {
        _Color_Sides ("Color_Sides", Color) = (1,0.5,0.4,1)
        _Color_Top ("Color_Top", Color) = (1,0.5,0.3,1)
        _Color_Front ("Color_Front", Color) = (0.8,0.2,0.2,1)
        _Bottom ("Bottom", Float ) = -0.5
        _Height ("Height", Float ) = 0.5
        _Color_Fog ("Color_Fog", Color) = (0.7,0.8,0.7,1)
        _Color_Inside ("Color_Inside", Color) = (0.6,0.1,0,1)
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
            Cull Off
            
            
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
            uniform float4 _Color_Top;
            uniform float4 _Color_Sides;
            uniform float4 _Color_Front;
            uniform float4 _Color_Fog;
            uniform float _Bottom;
            uniform float _Height;
            uniform float4 _Color_Inside;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 posWorld : TEXCOORD0;
                float3 normalDir : TEXCOORD1;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                i.normalDir = normalize(i.normalDir);
                i.normalDir *= faceSign;
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
////// Lighting:
                float3 Fog = _Color_Fog.rgb;
                float3 node_6308 = abs(i.normalDir);
                float3 Diffuse_Color = lerp(_Color_Inside.rgb,(node_6308.r*_Color_Sides.rgb + node_6308.g*_Color_Top.rgb + node_6308.b*_Color_Front.rgb),isFrontFace);
                float node_5579 = 0.0;
                float Height_Gradient = saturate((node_5579 + ( (i.posWorld.g - _Bottom) * (1.0 - node_5579) ) / (_Height - _Bottom)));
                float3 finalColor = lerp(Fog,Diffuse_Color,Height_Gradient);
                return fixed4(finalColor,1);
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            Cull Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #ifndef UNITY_PASS_SHADOWCASTER
            #define UNITY_PASS_SHADOWCASTER
            #endif //UNITY_PASS_SHADOWCASTER
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal d3d11_9x xboxone ps4 psp2 n3ds wiiu switch vulkan 
            #pragma target 3.0
            struct VertexInput {
                float4 vertex : POSITION;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
