using System;
using System.Collections.Generic;
using System.Text;

namespace Resolute_App
{
    class Question
    {

        private int firstNumber;
        private int secondNumber;
        private int answer;
        private int[] answerArray = new int[4];
        private char[] QuestionEquation = new char[4];
        private char EquationUse;
        private int answerPosition;
        //private int upperLimit;
        private string questionPhrase;
        private string wordPhrase;

        public Question(int upperLimit)
        {
            firstNumber = new Random().Next(upperLimit);
            secondNumber = new Random().Next(upperLimit - 0);
            QuestionEquation[0] = '+'; QuestionEquation[1] = '-';
            QuestionEquation[2] = '*'; QuestionEquation[3] = '/';

            Random rnd = new Random();
            int index = rnd.Next(QuestionEquation.Length);

            EquationUse = QuestionEquation[index];

            while (secondNumber == 0 & EquationUse == '/')
            {
                EquationUse = '+';
            }

            switch (EquationUse)
            {
                case '+':
                    answer = firstNumber + secondNumber;
                    break;
                case '-':
                    answer = firstNumber - secondNumber;
                    break;
                case '*':
                    answer = firstNumber * secondNumber;
                    break;
                case '/':
                    answer = firstNumber / secondNumber;
                    break;
            }

            questionPhrase = firstNumber + " " + EquationUse + " " + secondNumber + " = ";
            answerPosition = new Random().Next(4);


            this.answerArray[0] = answer + 1;
            this.answerArray[1] = answer + 4;
            this.answerArray[2] = answer + 7;
            this.answerArray[3] = answer + 2;

            ShuffleArray(this.answerArray);

            this.answerArray[answerPosition] = answer;

        }

        public int[] getAnswerArray()
        {
            return this.answerArray;
        }

        public void setQuestionPhrase(string questionPhrase)
        {
            this.questionPhrase = questionPhrase;
        }

        public string getQuestionPhrase()
        {
            return questionPhrase;
        }

        public int getAnswer()
        {
            return this.answer;
        }

        public void ShuffleArray(int[] array)
        {
            int randomIndex = new Random().Next(4);
            for (int i = 0; i < array.Length; i++)
            {
                int temp = array[randomIndex];
                array[randomIndex] = array[i];
                array[i] = temp;
            }

        }
    }
}
