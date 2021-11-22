using Godot;
//using Plugin.TextToSpeech;
using System;
//using System.Speech.Synthesis;
//using Microsoft.Speech.Synthesis;
//using System.Speech.Synthesis;
using Microsoft.Speech.Synthesis;

	public class Seaking : Node
	{
		public override void _Ready()
		{
		  // Initialize a new instance of the SpeechSynthesizer.  
		  SpeechSynthesizer synth = new SpeechSynthesizer();  
		  // Configure the audio output.   
		  synth.SetOutputToDefaultAudioDevice();  
		  // Speak a string.  
		  synth.Speak("This example demonstrates a basic use of Speech Synthesizer"); 
		  //await CrossTextToSpeech.Current.Speak("Text to speak");
		  
		}
	}
