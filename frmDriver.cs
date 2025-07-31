using System;
using System.Drawing;
using System.Reactive;
using System.Reactive.Linq;
using System.Threading;
using System.Windows.Forms;
using ASCOM.ArduinoUno.Dome;
using static ASCOM.LocalServer.SharedResources;

namespace ASCOM.LocalServer
{
    public partial class frmDriver : Form
    {
        private IDisposable roofStatusSubscription;
        private IDisposable safetyStatusSubscription;
        private IDisposable receivedStatusSubscription;

        public frmDriver()
        {
            InitializeComponent();
        }

        private void frmDriver_Load(object sender, EventArgs e)
        {
            var roofStatusObservable = Observable.FromEventPattern<EventHandler<EventArgs>, EventArgs>(
                handler => SharedResources.RoofStatusChanged += handler,
                handler => SharedResources.RoofStatusChanged -= handler);

            var safetyStatusObservable = Observable.FromEventPattern<EventHandler<EventArgs>, EventArgs>(
                handler => SharedResources.SafetyStatusChanged += handler,
                handler => SharedResources.SafetyStatusChanged -= handler);

            var receivedStatusObservable = Observable.FromEventPattern<EventHandler<EventArgs>, EventArgs>(
                handler => SharedResources.ReceivedStatusChanged += handler,
                handler => SharedResources.ReceivedStatusChanged -= handler);

            roofStatusSubscription = roofStatusObservable
                .ObserveOn(SynchronizationContext.Current)
                .Subscribe(ObserveRoofStatusChanged);

            safetyStatusSubscription = safetyStatusObservable
                .ObserveOn(SynchronizationContext.Current)
                .Subscribe(ObserveSafetyStatusChanged);

            receivedStatusSubscription = receivedStatusObservable
                .ObserveOn(SynchronizationContext.Current)
                .Subscribe(ObserveReceivedStatusChanged);
        }

        private void ObserveRoofStatusChanged(EventPattern<EventArgs> eventPattern)
        {
            UpdateRoofStatus(SharedResources.RoofStatus);
        }

        private void ObserveSafetyStatusChanged(EventPattern<EventArgs> eventPattern)
        {
            UpdateSafetyStatus(SharedResources.SafetyStatus);
        }

        private void ObserveReceivedStatusChanged(EventPattern<EventArgs> eventPattern)
        {
            UpdateArduinoStatus(SharedResources.ReceivedStatus);
        }

        private void UpdateRoofStatus(RoofStatusEnum status)
        {
            shutterStatusLbl.Text = status.ToString();

            switch (status)
            {
                case RoofStatusEnum.Open:
                    shutterStatusLbl.ForeColor = Color.Red;
                    break;
                case RoofStatusEnum.Closed:
                    shutterStatusLbl.ForeColor = Color.LimeGreen;
                    break;
                case RoofStatusEnum.Moving:
                    shutterStatusLbl.ForeColor = Color.Orange;
                    break;
                case RoofStatusEnum.Unknown:
                default:
                    shutterStatusLbl.ForeColor = Color.Black;
                    break;
            }
        }

        private void UpdateSafetyStatus(SafetyStatusEnum status)
        {
            safetyLbl.Text = status.ToString();

            switch (status)
            {
                case SafetyStatusEnum.Safe:
                    safetyLbl.ForeColor = Color.LimeGreen;
                    break;
                case SafetyStatusEnum.Unsafe:
                    safetyLbl.ForeColor = Color.Red;
                    break;
                case SafetyStatusEnum.Unknown:
                default:
                    safetyLbl.ForeColor = Color.Orange;
                    break;
            }
        }

        public void UpdateArduinoStatus(string status)
        {
            statusLbl.Text = status;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DomeHardware.OpenShutter();
        }

        private void btnClosed_Click(object sender, EventArgs e)
        {
            DomeHardware.CloseShutter();
        }
    }
}
