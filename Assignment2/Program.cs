        foreach (var wizard in WizardCollection.Create())
        {
            Console.WriteLine(wizard);
        }

        /* IEnumerable<IEnumerable<int>> xs = new List<List<int>>() { new List<int>() { 1, 2, 3, 4, 5 }, new List<int>() { 6, 7, 8, 9 } };
        IEnumerable<int> result = xs.SelectMany(x => x);
        Console.WriteLine("Results for xs:");
        foreach(int i in result) {
            Console.WriteLine(i);
        }

        int[] ys = new int[] { 14, 15, 16, 40, 42, 45, 49, 57, 68, 2000, 2020, 2022, 2014 };
        Predicate<int> chosen = Chosen;
        bool Chosen(int i) => i % 7 == 0 && i > 42;
        IEnumerable<int> ysResult = ys.Where(x => Chosen(x));
        Console.WriteLine("Results for ys:");
        foreach(int i in ysResult) {
            Console.WriteLine(i);
        }
        
        Predicate<int> leapYears = LeapYears;
        bool LeapYears(int i) => DateTime.IsLeapYear(i);
        IEnumerable<int> ysLeapYearResult = ys.Where(x => LeapYears(x));
        Console.WriteLine("Results for ys leap years:");
        foreach(int i in ysLeapYearResult) {
            Console.WriteLine(i);
        } */


        // Delegates / Anonymous

        // 1.
        Action<string> reverse = value => {
            var reversedValue = value.Reverse();
            foreach(char c in reversedValue) {
                Console.Write(c);
            }
        };

        reverse("Hello my friend");



        // 2.
        Func<int, int, int> product = (a, b) => a * b;
        Console.WriteLine(product(3, 5));

        // 3.

        Func<int, string, bool> numericallyEqual = (a, b) => {
            var c = int.Parse(b);
            if (a == c) return true;
            return false;
        };

        Console.WriteLine(numericallyEqual(5, "005"));