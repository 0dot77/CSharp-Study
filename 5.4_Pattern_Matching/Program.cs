using System;
using System.Runtime.InteropServices;

namespace _5._4_Pattern_Matching
{
    class Preschooler { }
    class Underage { }
    class Adult { }
    class Senior { }

    class Car
    {
        public string Model { get; set;}
        public DateTime ProducedAt { get; set;}
    }

    class OrderItem
    {
        public int Amount { get; set;}
        public int Price { get; set;}
    }

    internal class Program
    {
        // 상수 패턴
        static int CalculateFee(object visitor)
        {
            return visitor switch
            {
            Underage => 100,
            Adult => 500,
            Senior => 200,
            // Underage, Adult, Senior가 아니면 아래의 에러를 띄운다.
            _ => throw new ArgumentException(
                $"Prohibited age: {visitor.GetType()}", nameof(visitor)),
            };
        }

        // 프로퍼티 패턴
        static string GetNickname(Car car) // 자동차의 클래스를 받아서 처리하는 함수
        {
            var GenerateMessage = (Car car, string nickname) => $"{car.Model} produced in {car.ProducedAt} is {nickname}";

            if (car is Car { Model: "Mustang", ProducedAt.Year: 1967 }) // 클래스 파라미터를 패턴 매칭 해준다.
                return GenerateMessage(car, "Fastback");

            else if (car is Car { Model: "Mustang", ProducedAt.Year: 1976 })
                return GenerateMessage(car, "Cobra 2");

            else
                return GenerateMessage(car, "Unknown");
        }

        static string GetNicknameUsingIs(Car car)
        {
            var GenerateMessage = (Car car, string nickname) => $"{car.Model} produced in {car.ProducedAt} is {nickname}";

            return car switch
            {
                { Model: "Mustang", ProducedAt.Year: 1967 } => GenerateMessage(car, "Fastback"),
                { Model: "Mustang", ProducedAt.Year: 1976} => GenerateMessage(car,"Cobra 2")
            };
        }

        // 논리 패턴

        static double GetPrice(OrderItem orderItem) => orderItem switch
        {
            OrderItem { Amount: 0 } or OrderItem { Price: 0 } => 0.0,
            OrderItem { Amount: >= 100 } and OrderItem { Price: >= 10_000 } => orderItem.Amount * orderItem.Price * 0.8,
        };
        

        static void Main(string[] args)
        {
            /*
                        // #### 선언 패턴 ####

                        object foo = 23;

                        if (foo is int bar)
                        {
                            Console.WriteLine(bar);
                            Console.WriteLine(23);
                        }
            */

            /*
                        // #### 형식 패턴 01 ####

                        object foo = 23;

                        if(foo is int)
                        {
                            Console.WriteLine(foo);
                        }

            */

            /*
                        // #### 형식 패턴 02 ####

                        Console.WriteLine($"Fee for a senior: {CalculateFee(new Senior())}");
                        Console.WriteLine($"Fee for a adult: {CalculateFee(new Adult())}");
                        Console.WriteLine($"Fee for a underage: {CalculateFee(new Underage())}");
                        Console.WriteLine($"Fee for a preschooler: {CalculateFee(new Preschooler())}");
            */
            /*
                        // #### 상수 패턴 ####

                        var GetCountryCode = (string nation) => nation switch
                        {
                            "KR" => 82,
                            "US" => 1,
                            "UK" => 44,
                            _ => throw new ArgumentException("Not supported Code")
                        };

                        Console.WriteLine(GetCountryCode("KR"));
                        Console.WriteLine(GetCountryCode("US"));
                        Console.WriteLine(GetCountryCode("UA"));
                    }
            */
            /*
                        // #### 상수 패턴 예제 만들기 ####

                        var GetMonsterAttack = (int damage) => damage switch
                        {
                            10 => "약한 데미지",
                            50 => "아주 강력한걸?",
                            100 => "뭘 먹은거야?!",
                            _ => throw new ArgumentException("데미지 측정 불가")
                        };

                        Console.WriteLine(GetMonsterAttack(50));
            */
            /*
                        // #### 프로퍼티 패턴 ####

                        Console.WriteLine(
                            GetNickname(
                                new Car() { Model = "Mustang", ProducedAt = new DateTime(1967, 11, 23) })
                        );
            */
            /*
                        // #### 프로퍼티 패턴 is로 구현하기 ####

                        Console.WriteLine(
                            GetNicknameUsingIs(
                                new Car() { Model = "Mustang", ProducedAt = new DateTime(1976, 11, 23) }
                                ));
            */
            /*
                        // #### 논리 패턴 ####

                        Console.WriteLine(GetPrice(new OrderItem() { Amount = 0, Price = 10_000 }));

            */

            // #### 괄호 패턴 ####
            /*
                        object foo = 30;

                        if (foo is (int and > 19))
                            Console.WriteLine("통과");
            */
            /*
                        // #### 위치 패턴 ####

                        Tuple<string, int> itemPrice = new Tuple<string, int>("espresso", 3000);

                        if(itemPrice is ("espresso", <5000))
                        {
                            Console.WriteLine("The Coffee is affordable.");
                        }

            */
            /*
                        // #### var 패턴 ####

                        var isPassed = (int[] scores) => scores.Sum() / scores.Length is var average && Array.TrueForAll(scores, (score) => score >= 60) && average >= 60;

                        int[] scores1 = { 90, 80, 30, 80, 70 };

                        Console.WriteLine($"{string.Join(",", scores1)}: Pass:{isPassed(scores1)}");
            */

            // #### 목록 패턴 ####
/*
            var match = (int[] array) => array is [int, > 10, _];

            Console.WriteLine(match(new int[] {1, 100, 3}));
*/
        }
    }
}