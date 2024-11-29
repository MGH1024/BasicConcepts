
// مزایای وراثت:
// کاهش تکرار کد:
//
// ویژگی‌ها و رفتارهای مشترک در کلاس والد تعریف می‌شوند و دیگر نیازی به تکرار آن‌ها در کلاس‌های فرزند نیست.
//     قابلیت گسترش:
//
// می‌توانید رفتارهای جدید را به کلاس‌های فرزند اضافه کنید یا متدهای کلاس والد را بازنویسی (Override) کنید.
//     ساختار منطقی:
//
// کد شما ساختارمندتر و ساده‌تر برای درک و نگهداری می‌شود.



using Inheritance;

Bird parrot = new Bird { Name = "Parrot", Age = 2 };
parrot.Eat();
parrot.Fly();

Fish goldfish = new Fish { Name = "Goldfish", Age = 1 };
goldfish.Eat();
goldfish.Swim();

Dog bulldog = new Dog { Name = "Bulldog", Age = 3 };
bulldog.Eat();
bulldog.Bark();

Console.ReadKey();