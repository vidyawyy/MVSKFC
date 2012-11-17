﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace AnimatedSprites
{
    /// <summary>
    /// 这是一个实现 IUpdateable 的游戏组件。
    /// </summary>
    public class GameStarManager : Microsoft.Xna.Framework.GameComponent
    {
        public GameStarManager(Game game)
            : base(game)
        {
            // TODO: 在此处构造任何子组件
        }

        /// <summary>
        /// 允许游戏组件在开始运行之前执行其所需的任何初始化。
        /// 游戏组件能够在此时查询任何所需服务和加载内容。
        /// </summary>
        public override void Initialize()
        {
            // TODO: 在此处添加初始化代码

            base.Initialize();
        }

        /// <summary>
        /// 允许游戏组件进行自我更新。
        /// </summary>
        /// <param name="gameTime">提供计时值的快照。</param>
        public override void Update(GameTime gameTime)
        {
            // TODO: 在此处添加更新代码

            base.Update(gameTime);
        }
    }
}
