using System;
using UnityEngine;

namespace Editor
{
    [CreateAssetMenu(menuName="MySubMenue/Create MyScriptableObject ")]
    public class ProfilerSetting : ScriptableObject
    {
        /// <summary>
        /// 检测ParticleSystem是否开启了Collision或者Trigger
        /// </summary>
        public bool checkCollision = true;

        /// <summary>
        /// DrawCall检测
        /// </summary>
        public bool checkDrawCall = true;

        /// <summary>
        /// 检测OverDraw
        /// </summary>
        public bool checkOverDraw = true;

        /// <summary>
        /// 检测当前特效总内存
        /// </summary>
        public bool checkTotalMemory = true;

        //Texture
        public TextureSetting textureSetting;

        //Animation
        public AnimationSetting animationSetting;

        //Mesh
        public MeshSetting meshSetting;

        //Shader
    }

    [Serializable]
    public class TextureSetting
    {
        /// <summary>
        /// 检测Mipmap
        /// </summary>
        public bool checkMipmap = true;
        /// <summary>
        /// 检测Read/Write
        /// </summary>
        public bool checkReadWrite = true;
        /// <summary>
        /// 检测图片格式
        /// </summary>
        public bool checkFormatStandalone = true;

        public bool checkFormatAndroid = true;

        public bool checkFormatIphone = true;
        
        /// <summary>
        /// 允许的最大图片大小
        /// </summary>
        public int textureMaxSize = 2048;
    }

    [Serializable]
    public class AnimationSetting
    {
        /// <summary>
        /// 检测是否包含Scale曲线
        /// </summary>
        public bool checkScale = true;
        
        /// <summary>
        /// 检测动画精度
        /// </summary>
        public bool checkPrecision = true;
    }

    [Serializable]
    public class MeshSetting
    {
        /// <summary>
        /// 检测Mesh包含Normal
        /// </summary>
        public bool checkNormal = true;
        
        /// <summary>
        /// 检测Mesh包含Tangent
        /// </summary>
        public bool checkTangent = true;
        
        /// <summary>
        /// 检测Mesh包含Color
        /// </summary>
        public bool checkColor = true;
        
        /// <summary>
        /// 检测Mesh未开启Read/Write
        /// </summary>
        public bool checkReadWrite = true;
    }
}