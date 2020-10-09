﻿ using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using System.Data.SqlClient;
using Effortless.Net.Encryption;
using CSVFile;
using System.Collections.Generic;
using System.Configuration;
using GoogleTranslateFreeApi;
using System.Threading;

namespace TrialsProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var translator = new GoogleTranslator();

            Language from = Language.Auto;
            Language to = GoogleTranslator.GetLanguageByName("French");
            string text = @"Amy normally hated Monday mornings, but this year was different. Kamal was in her art class and she liked Kamal. She was waiting outside the classroom when her friend Tara arrived.

“Hi Amy!Your mum sent me a text.You forgot your inhaler. Why don’t you turn your phone on?” Amy didn’t like technology.She never sent text messages and she hated Facebook too.

“Did Kamal ask you to the disco ?” Tara was Amy’s best friend, and she wanted to know everything that was happening in Amy’s life. “I don’t think he likes me,” said Amy. “And I never see him alone. He’s always with Grant.” Amy and Tara didn’t like Grant.

“Do you know about their art project ?” asked Amy. “It’s about graffiti, I think,” said Tara. “They’re working on it at the old house behind the factory.” “But that building is dangerous,” said Amy. “Aah, are you worried he’s going to get hurt ?  Tara teased. “Shut up, Tara! Hey look, here they come!
 

 Kamal and Grant arrived. “Hi Kamal!” said Tara. “Are you going to the Halloween disco tomorrow?” “Yes.Hi Amy,” Kamal said, smiling. “Do you want to come and see our paintings after school ?” “I’m coming too!” Tara insisted.

After school, Kamal took the girls to the old house.It was very old and very dirty too. There was rubbish everywhere. The windows were broken and the walls were damp.It was scary.Amy didn’t like it.There were paintings of zombies and skeletons on the walls. “We’re going to take photos for the school art competition,” said Kamal.Amy didn’t like it but she didn’t say anything. “Where’s Grant ?” asked Tara. “Er, he’s buying more paint.” Kamal looked away quickly.Tara thought he looked suspicious. “It’s getting dark, can we go now ?” said Amy.She didn’t like zombies.

Then, they heard a loud noise coming from a cupboard in the corner of the room. “What’s that ?” Amy was frightened. “I didn’t hear anything,” said Kamal.Something was making strange noises.There was something inside the cupboard. “Oh no! What is it?” Amy was very frightened now. “What do you mean? There’s nothing there!” Kamal was trying not to smile. Suddenly the door opened with a bang and a zombie appeared, shouting and moving its arms.Amy screamed and covered her eyes. “Oh very funny, Grant!” said Tara looking bored. Kamal and Grant started laughing. “Ha ha, you were frightened!” said Grant. Do you like my zombie costume?” Amy took Tara’s arm. “I can’t breathe,” she said. Kamal looked worried now. “Is she OK? It was only a joke.” “No she’s not OK, you idiot. She’s having an asthma attack and she forgot her inhaler.” Tara took out her phone. “I’m calling her dad.

Next evening was Halloween. The girls were at the school disco. “Are you better now?” asked Tara. “I’m fine,” said Amy. “I think it was the smell of paint that started the attack.” Tara looked around. “So, where are the zombies?” “I don’t know, I don’t want to see Kamal again,” said Amy. “Come on, let’s dance!”

Amy and Tara were dancing when Grant arrived, looking worried. “Hi, someone stole my phone. Have you seen Kamal? He said he was coming here at eight o’clock.Can you phone him?” “Go away, idiot!” Tara didn’t stop dancing.Grant looked upset. “Tell him I’m looking for him,” he called as he left the disco.Tara really didn’t like Grant.


Just then, Tara’s phone rang.She looked at it. “Ha!” she said, “I don’t believe it!” “What is it?” asked Amy. “Kamal just sent a text to everyone.Listen!” Tara read out Kamal’s message.

“I’m at the house.I can’t move.Please call an ambulance.My battery is running out.”


The girls didn’t stop dancing.Lots of their friends saw Kamal’s message too, but Tara told everyone it was just a joke.They all ignored it.


The next morning, Amy’s mum and dad were listening to the radio. “Is Amy up yet ?” Dad asked. “No, she’s tired,” said mum, turning the volume up on the radio.

“This morning, police are investigating the death of a sixteen - year - old boy.He died last night in a disused house on Moortown Road...”


Dad put down his newspaper. “But that’s where Amy went with her friends.";
            int i = 0;
            do
            {
                TranslationResult result = translator.TranslateLiteAsync(text, from, to).Result;

                //The result is separated by the suggestions and the '\n' symbols
                string[] resultSeparated = result.FragmentedTranslation;

                //You can get all text using MergedTranslation property
                string resultMerged = result.MergedTranslation;

                //There is also original text transcription
                string transcription = result.TranslatedTextTranscription; // Kon'nichiwa! Ogenkidesuka?
                Console.WriteLine(resultMerged +" "+i+"\n\n\n\n\n");
                i++;
                Thread.Sleep(2000);
            } while (true);
        }
    }
}