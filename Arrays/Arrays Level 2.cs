using System;

class Level1Final
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Q1");
        double[] salary = new double[10];
        double[] service = new double[10];
        double[] bonus = new double[10];
        double[] newSalary = new double[10];
        double totalBonus = 0, totalOld = 0, totalNew = 0;

        for (int i = 0; i < 10; i++)
        {
            salary[i] = Convert.ToDouble(Console.ReadLine());
            service[i] = Convert.ToDouble(Console.ReadLine());
            if (salary[i] <= 0 || service[i] < 0)
            {
                i--;
                continue;
            }
        }

        for (int i = 0; i < 10; i++)
        {
            if (service[i] > 5)
                bonus[i] = salary[i] * 0.05;
            else
                bonus[i] = salary[i] * 0.02;

            newSalary[i] = salary[i] + bonus[i];
            totalBonus += bonus[i];
            totalOld += salary[i];
            totalNew += newSalary[i];
        }

        Console.WriteLine(totalBonus);
        Console.WriteLine(totalOld);
        Console.WriteLine(totalNew);

        Console.WriteLine("Q2");
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] age = new int[3];
        double[] height = new double[3];

        for (int i = 0; i < 3; i++)
        {
            age[i] = Convert.ToInt32(Console.ReadLine());
            height[i] = Convert.ToDouble(Console.ReadLine());
        }

        int youngest = 0, tallest = 0;
        for (int i = 1; i < 3; i++)
        {
            if (age[i] < age[youngest]) youngest = i;
            if (height[i] > height[tallest]) tallest = i;
        }

        Console.WriteLine(names[youngest]);
        Console.WriteLine(names[tallest]);

        Console.WriteLine("Q3");
        int num = Convert.ToInt32(Console.ReadLine());
        int maxDigit = 10;
        int[] digits = new int[maxDigit];
        int index = 0;

        while (num != 0 && index < maxDigit)
        {
            digits[index++] = num % 10;
            num /= 10;
        }

        int largest = 0, secondLargest = 0;
        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
                secondLargest = digits[i];
        }

        Console.WriteLine(largest);
        Console.WriteLine(secondLargest);

        Console.WriteLine("Q4");
        num = Convert.ToInt32(Console.ReadLine());
        maxDigit = 10;
        digits = new int[maxDigit];
        index = 0;

        while (num != 0)
        {
            if (index == maxDigit)
            {
                maxDigit += 10;
                int[] temp = new int[maxDigit];
                for (int i = 0; i < index; i++)
                    temp[i] = digits[i];
                digits = temp;
            }
            digits[index++] = num % 10;
            num /= 10;
        }

        largest = 0;
        secondLargest = 0;
        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
                secondLargest = digits[i];
        }

        Console.WriteLine(largest);
        Console.WriteLine(secondLargest);

        Console.WriteLine("Q5");
        num = Convert.ToInt32(Console.ReadLine());
        int count = num.ToString().Length;
        int[] arr = new int[count];

        for (int i = 0; i < count; i++)
        {
            arr[i] = num % 10;
            num /= 10;
        }

        for (int i = 0; i < count; i++)
            Console.Write(arr[i]);

        Console.WriteLine();

        Console.WriteLine("Q6");
        int persons = Convert.ToInt32(Console.ReadLine());
        double[] weight = new double[persons];
        double[] heightArr = new double[persons];
        double[] bmi = new double[persons];
        string[] status = new string[persons];

        for (int i = 0; i < persons; i++)
        {
            weight[i] = Convert.ToDouble(Console.ReadLine());
            heightArr[i] = Convert.ToDouble(Console.ReadLine());
            bmi[i] = weight[i] / (heightArr[i] * heightArr[i]);

            if (bmi[i] < 18.5) status[i] = "Underweight";
            else if (bmi[i] < 25) status[i] = "Normal";
            else if (bmi[i] < 30) status[i] = "Overweight";
            else status[i] = "Obese";
        }

        for (int i = 0; i < persons; i++)
            Console.WriteLine($"{heightArr[i]} {weight[i]} {bmi[i]} {status[i]}");

        Console.WriteLine("Q7");
        persons = Convert.ToInt32(Console.ReadLine());
        double[][] personData = new double[persons][];
        string[] bmiStatus = new string[persons];

        for (int i = 0; i < persons; i++)
            personData[i] = new double[3];

        for (int i = 0; i < persons; i++)
        {
            personData[i][0] = Convert.ToDouble(Console.ReadLine());
            personData[i][1] = Convert.ToDouble(Console.ReadLine());
            personData[i][2] = personData[i][0] / (personData[i][1] * personData[i][1]);

            if (personData[i][2] < 18.5) bmiStatus[i] = "Underweight";
            else if (personData[i][2] < 25) bmiStatus[i] = "Normal";
            else if (personData[i][2] < 30) bmiStatus[i] = "Overweight";
            else bmiStatus[i] = "Obese";
        }

        for (int i = 0; i < persons; i++)
            Console.WriteLine($"{personData[i][1]} {personData[i][0]} {personData[i][2]} {bmiStatus[i]}");

        Console.WriteLine("Q8");
        int students = Convert.ToInt32(Console.ReadLine());
        int[,] marks = new int[students, 3];
        double[] percentage = new double[students];
        string[] grade = new string[students];

        for (int i = 0; i < students; i++)
        {
            marks[i, 0] = Convert.ToInt32(Console.ReadLine());
            marks[i, 1] = Convert.ToInt32(Console.ReadLine());
            marks[i, 2] = Convert.ToInt32(Console.ReadLine());

            percentage[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3.0;

            if (percentage[i] >= 90) grade[i] = "A";
            else if (percentage[i] >= 75) grade[i] = "B";
            else if (percentage[i] >= 60) grade[i] = "C";
            else grade[i] = "D";
        }

        for (int i = 0; i < students; i++)
            Console.WriteLine($"{percentage[i]} {grade[i]}");

        Console.WriteLine("Q9");
        num = Convert.ToInt32(Console.ReadLine());
        count = num.ToString().Length;
        int[] dig = new int[count];

        for (int i = 0; i < count; i++)
        {
            dig[i] = num % 10;
            num /= 10;
        }

        int[] freq = new int[10];
        for (int i = 0; i < count; i++)
            freq[dig[i]]++;

        for (int i = 0; i < 10; i++)
            if (freq[i] > 0)
                Console.WriteLine($"{i} {freq[i]}");

        Console.WriteLine("Q10");
        int rows = Convert.ToInt32(Console.ReadLine());
        int cols = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());

        int[] oneD = new int[rows * cols];
        int pos = 0;

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                oneD[pos++] = matrix[i, j];

        for (int i = 0; i < oneD.Length; i++)
            Console.WriteLine(oneD[i]);
    }
}