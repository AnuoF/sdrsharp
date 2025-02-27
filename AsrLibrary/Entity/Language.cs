﻿/*********************************************************************************************
 *	
 * 文件名称:    Language.cs
 * 
 * 描    述：   语种类，用于封装从配置文件读取的信息。
 *
 * 作    者:    王 喜 进
 *	
 * 创作日期:    2019-2-27
 *
 * 备    注:	
 *                                        
*********************************************************************************************/


namespace AsrLibrary.Entity
{
    /// <summary>
    /// 语种类
    /// </summary>
    public class Language
    {
        /// <summary>
        /// 语种类别
        /// </summary>
        public string Name;

        /// <summary>
        /// 语种名称
        /// </summary>
        public string Text;

        /// <summary>
        /// 具备该语种识别能力的 SDK
        /// </summary>
        public string Capacity;

        /// <summary>
        /// 对应 SDK 类型
        /// </summary>
        public string Engine;

        /// <summary>
        /// 是否有效。 从配置文件读取时，已将其赋值为true
        /// </summary>
        public bool Valid = false;
    }
}
