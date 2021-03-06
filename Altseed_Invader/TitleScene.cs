﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	class TitleScene : asd.Scene
	{
		public TitleScene()
		{
			asd.Layer2D layer = new asd.Layer2D();
			asd.Font font48= asd.Engine.Graphics.CreateDynamicFont( "",48, new asd.Color(255, 255, 255, 255), 2, new asd.Color(255, 100, 100, 255));
			asd.Font font12 = asd.Engine.Graphics.CreateDynamicFont("", 12, new asd.Color(255, 255, 255, 255), 0, new asd.Color(0, 0, 0, 0));

			asd.TextObject2D title = new asd.TextObject2D();
			title.Font = font48;
			title.Text = "INVADER";
			float titleWidth = font48.CalcTextureSize(title.Text, asd.WritingDirection.Horizontal).X;
			title.Position = new asd.Vector2DF((asd.Engine.WindowSize.To2DF().X - titleWidth) / 2, 250);
			layer.AddObject(title);

			asd.TextObject2D prompt = new asd.TextObject2D();
			prompt.Font = font12;
			prompt.Text = "PRESS SPACE KEY TO START";
			float promptWidth = font12.CalcTextureSize(prompt.Text, asd.WritingDirection.Horizontal).X;
			prompt.Position = new asd.Vector2DF((asd.Engine.WindowSize.To2DF().X - promptWidth) / 2, 400);
			layer.AddObject(prompt);

			AddLayer(layer);
		}

		protected override void OnUpdating()
		{
			if (asd.Engine.Keyboard.GetKeyState(asd.Keys.Space) == asd.KeyState.Push)
			{
				asd.Engine.ChangeSceneWithTransition(new GameScene(),new asd.TransitionFade(1.0f,1.0f));
			}
		}
	}
}
