using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Windows.Forms;

namespace TTS
{
    public partial class MainForm : Form
    {
        // Current voice
        private String voice = "";
        // Is SSML enabled
        private bool SSMLMode = false;
        // Is it speaking
        private bool IsSpeaking = false;
        // Initialize a new instance of the SpeechSynthesizer.  
        private SpeechSynthesizer synth = new SpeechSynthesizer();
        // Save file dialog 
        private SaveFileDialog saveFileDialog = new SaveFileDialog();

        public MainForm()
        {
            InitializeComponent();

            saveFileDialog.FileOk += SaveFileDialog_FileOk;

            synth.SpeakStarted += Synth_SpeakStarted;
            synth.SpeakCompleted += Synth_SpeakCompleted;
            synth.SpeakProgress += Synth_SpeakProgress;
        }

        private void Synth_SpeakProgress(object sender, SpeakProgressEventArgs e)
        {
        }

        private void Synth_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            IsSpeaking = false;
        }

        private void Synth_SpeakStarted(object sender, SpeakStartedEventArgs e)
        {
            IsSpeaking = true;
        }

        private void SaveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            // Configure the audio output.   
            synth.SetOutputToWaveFile(saveFileDialog.FileName);

            // Select a voice.
            synth.SelectVoice(voice);

            // Set the rate.
            synth.Rate = (int)rate.Value;

            if (SSMLMode)
            {
                // Speak SSML
                synth.SpeakSsmlAsync(ssmlInput.Text);
            }
            else
            {
                // Speak a string.  
                synth.SpeakAsync(textInput.Text);
            }
        }

        private void speakBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsSpeaking)
                {
                    SSMLMode = ssmlInput.Text != "";

                    if (textInput.Text.Equals("") && !SSMLMode)
                    {
                        MessageBox.Show(this, "Enter a text for the TTS to speak", "TTSBoard", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Configure the audio output.   
                    synth.SetOutputToDefaultAudioDevice();

                    // Select a voice.
                    synth.SelectVoice(voice);

                    // Set the rate.
                    synth.Rate = (int)rate.Value;

                    if (SSMLMode)
                    {
                        // Speak SSML
                        synth.SpeakSsmlAsync(ssmlInput.Text);
                    }
                    else
                    {
                        // Speak a string.  
                        synth.SpeakAsync(textInput.Text);
                    }
                }

            } catch (ArgumentException ex)
            {
                MessageBox.Show(this, "Select a voice to speak", "TTSBoard", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex)
            {
                MessageBox.Show(this, "Something went wrong while trying to convert your text to vocal speech...", "TTSBoard", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void msJira_CheckedChanged(object sender, EventArgs e)
        {
            voice = "Microsoft Zira Desktop";
        }

        private void msDavid_CheckedChanged(object sender, EventArgs e)
        {
            voice = "Microsoft David Desktop";
        }

        private void credits_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "http://github.com/YedoxStudios/TTSBoard",
                UseShellExecute = true
            });
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "*.wav|Wave Files";
            saveFileDialog.Title = "Save TTS voice as...";
            saveFileDialog.DefaultExt = "*.wav|Wave Files";
            saveFileDialog.InitialDirectory = "%userprofile%";

            saveFileDialog.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
