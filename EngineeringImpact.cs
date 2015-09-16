using System;
using System.Linq;
using System.Windows.Forms;

namespace EngineeringImpact
{
	public partial class EngineeringImpact : Form
	{
/* 1*/	private System.Timers.Timer timer = new System.Timers.Timer(15);
/* 2*/	private String ImpactText = "Engineering Impact";
/* 3*/	private int Delta = 1;
/* 4*/	private int Spacing = 0;
/* 5*/	private int MaxSpacing = 10;

		public EngineeringImpact()
		{
			InitializeComponent();
/* 6*/		timer.Elapsed += OnTimer;
/* 7*/		timer.SynchronizingObject = this;
		}

/* 8*/		private void OnClick(object sender, EventArgs e)
/* 9*/		{
/*10*/			if (!timer.Enabled)
/*11*/			{
/*12*/				timer.Start();
/*13*/				new System.Media.SoundPlayer(Properties.Resources.Boing).Play();
/*14*/			}
/*15*/		}

/*16*/		private void OnTimer(Object source, System.Timers.ElapsedEventArgs e)
/*17*/		{
/*18*/			Button.Text = String.Join(new String(' ', Spacing=Spacing+Delta), ImpactText.ToCharArray().Select(c => c.ToString()).ToArray());
/*19*/			Delta = (Spacing == MaxSpacing || Spacing == 0) ? -Delta : Delta;
/*20*/			if (Spacing == 0 && --MaxSpacing == 0)
/*21*/			{
/*22*/				if ((source as System.Timers.Timer) != null) (source as System.Timers.Timer).Stop();
/*23*/
/*24*/				Delta = 1;
/*25*/				Spacing = 0;
/*26*/				MaxSpacing = 10;
/*27*/			}
/*28*/		}
	}
}
