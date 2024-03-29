﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GradientControl.ViewModel
{
	public class MainPageViewModel : INotifyPropertyChanged
    {
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		private bool isAnimating = true;
		public bool IsAnimating
		{
			get
			{
				return isAnimating;
			}
			set
			{
				if (isAnimating != value)
				{
					isAnimating = value;
					NotifyPropertyChanged();
				}
			}
		}

		private int fps = 60;
		public int Fps
		{
			get
			{
				return fps;
			}
			set
			{
				if (fps != value)
				{
					fps = value;
					NotifyPropertyChanged();
				}
			}
		}

		private int framesPerTransition = 3000;
		public int FramesPerTransition
		{
			get
			{
				return framesPerTransition;
			}
			set
			{
				if (framesPerTransition != value)
				{
					framesPerTransition = value;
					NotifyPropertyChanged();
				}
			}
		}
	}
}