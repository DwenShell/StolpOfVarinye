Shader "Custom/MaskInvert"
{
	Properties
	{
		_Color ("Main Color", Color) = (1,1,1,1)

		_MainTex ("Base (RGB) Gloss (A)", 2D) = "White" {}
	}

	Category
	{
		SubShader
		{
			Tags {"Queue" = "Transparent+1"}

			Pass
			{
				ZWrite On
				ZTest Greater
				Lighting On
				SetTexture [_MainTex] {}
			}
		}
	}

	FallBack "Specular",1
}
