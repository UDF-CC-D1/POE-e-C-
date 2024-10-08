using System;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;

namespace TrafficLightSimulationGUI
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer timer;
        private System.Windows.Forms.Timer countdownTimer; // Timer para atualizar o tempo restante
        private string currentLight = "Green";
        private bool pedestrianButtonPressed = false;
        private int timeRemaining;

        public Form1()
        {
            InitializeComponent();

            // Inicializa os timers no construtor para evitar nulidade
            timer = new System.Timers.Timer();
            countdownTimer = new System.Windows.Forms.Timer();

            InitializeTrafficLight();
        }

        private void InitializeTrafficLight() // Método
        {
            // Configura o timer principal
            timer.Interval = 10000; // Inicializa com 10 segundos para a mudança de verde para amarelo
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = false;

            // Configura o timer de contagem regressiva
            countdownTimer.Interval = 1000; // 1 segundo
            countdownTimer.Tick += CountdownTimer_Tick;

            // Inicializa o estado inicial das luzes
            SetTrafficLight("Green");
            LabelCountdown.Text = "";
        }

        private void OnTimedEvent(object? source, ElapsedEventArgs e) // Evento
        {
            if (currentLight == "Green" && pedestrianButtonPressed)
            {
                currentLight = "Yellow";
                Invoke(new Action(() => SetTrafficLight("Yellow")));
                StartCycle(5); // Espera 5 segundos para mudar para vermelho
            }
            else if (currentLight == "Yellow")
            {
                currentLight = "Red";
                Invoke(new Action(() => SetTrafficLight("Red")));
                StartCycle(20); // Espera 20 segundos no vermelho
            }
            else if (currentLight == "Red")
            {
                currentLight = "Green";
                pedestrianButtonPressed = false; // Reseta o estado do botão
                Invoke(new Action(() => SetTrafficLight("Green")));
                LabelCountdown.Text = ""; // Reinicia para o estado de espera
            }
        }

        private void CountdownTimer_Tick(object? sender, EventArgs e) // Evento
        {
            if (timeRemaining > 0)
            {
                timeRemaining--;
                LabelCountdown.Text = $"Tempo: {timeRemaining}s";
            }
        }

        private void SetTrafficLight(string color) // Método
        {
            // Define todas as cores como cinza (apagadas)
            PanelRed.BackColor = Color.Gray;
            PanelYellow.BackColor = Color.Gray;
            PanelGreen.BackColor = Color.Gray;

            // Ativa a cor correspondente
            switch (color)
            {
                case "Red":
                    PanelRed.BackColor = Color.Red;
                    break;
                case "Yellow":
                    PanelYellow.BackColor = Color.Yellow;
                    break;
                case "Green":
                    PanelGreen.BackColor = Color.Green;
                    break;
            }
        }

        private void ButtonPedestrian_Click(object sender, EventArgs e) // Evento
        {
            if (currentLight == "Green" && !pedestrianButtonPressed)
            {
                pedestrianButtonPressed = true;
                Console.WriteLine("");
                StartCycle(10); // Espera 10 segundos para mudar para amarelo
            }
        }

        private void StartCycle(int seconds) // Método
        {
            timeRemaining = seconds;
            LabelCountdown.Text = $"Tempo: {timeRemaining}s";
            countdownTimer.Start();
            timer.Interval = seconds * 1000; // Define o intervalo do timer principal
            timer.Start();
        }
    }
}
