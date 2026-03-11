using System;
using System.Runtime.InteropServices;

// README.md를 읽고 코드를 작성하세요.
//Console.WriteLine("'''");
//{
//    Notify notify = SayHello;
//    notify += SayGoodbye;

//    notify();

//    void SayHello()
//    {
//        Console.WriteLine("안녕하세요!");
//    }
//    void SayGoodbye()
//    {
//        Console.WriteLine("안녕히 가세요!");
//    }

//    delegate void Notify();
//}
//Console.WriteLine("'''\n");

//Console.WriteLine("'''");
//{
//    Button button = new Button();
//    button.Click += HandleClick;
//    button.Click += HandleClickAgain;

//    button.OnClick();

//    void HandleClick()
//    {
//        Console.WriteLine("버튼이 클릭되었습니다!");
//    }
//    void HandleClickAgain()
//    {
//        Console.WriteLine("클릭 처리 완료");
//    }
//    delegate void EventHandler();
//}
//Console.WriteLine("'''\n");

//Console.WriteLine("'''");
//{
//    Player player = new Player();
//    HealthBar healthBar = new HealthBar();
//    SoundManager soundManager = new SoundManager();
//    player.DamageTaken += healthBar.OnPlayerDamaged;
//    player.DamageTaken += soundManager.OnPlayerDamaged;

//    player.TakeDamage(30);

//}
//Console.WriteLine("'''\n");

//Console.WriteLine("'''");
//{
//    Timer timer = new Timer();
//    Logger logger = new Logger();
//    timer.Tick += logger.OnTick;
//    timer.Start();
//    timer.Start();
//    timer.Start();
//    timer.Tick -= logger.OnTick;
//    timer.Start();
//    timer.Start();
//    timer.Start();
//}
//Console.WriteLine("'''\n");

//Console.WriteLine("'''");
//{
//    Sensor sensor = new Sensor();
//    sensor.Alter += message =>
//    {
//        Console.WriteLine($"[경보]{message}");
//    };
//    sensor.Alter += message =>
//    {
//        Console.WriteLine($"[로그]{DateTime.Now}: {message}");
//    };
//}
//Console.WriteLine("'''\n");

//Console.WriteLine("'''");
//{
//    GameCharacter character = new GameCharacter("용사");

//    character.OnDeath += () => Console.WriteLine("캐릭터가 사망했습니다");
//    character.OnDamaged += health = Console.WriteLine($"남은 체력: {health}");
//    character.OnAttack += (damage, target) => Console.WriteLine($"{target}에게 {damage} 데미지!");

//    character.Attack(50, "슬라임");
//    character.TakeDamage(30);
//    character.TakeDamage(80);
//}
//Console.WriteLine("'''\n");

//Console.WriteLine("'''");
//{
//    Stock stock = new Stock("MSFT", 100.00m);

//    stock.PriceChanged += (sender, e) =>
//    {
//        Stock stock = (Stock)sender;
//        Console.WriteLine($"[{stock}]");
//        Console.WriteLine($"  이전 가격: {e.OldPrice:C}");
//        Console.WriteLine($"  현재 가격: {e.NewPrice:C}");
//        Console.WriteLine($"  변동률: {e.ChangePercent:F2}%");
//        Console.WriteLine();
//    };
//    msStock.Price = 110.00m;
//    msStock.Price = 105.50m;
//    msStock.Price = 120.00m;
//}
//Console.WriteLine("'''\n");

//Console.WriteLine("'''");
//{
//    Car car = new Car(50);
//    Dashboard dashboard = new Dashboard();

//    dashboard.Subscribe(car);
//    for(int i = 0; i < 7; i++)
//    {
//        car.Drive();
//        Console.WriteLine();
//    }
//    dashboard.Unsubscribe(car);
//}
//Console.WriteLine("'''\n");

//Console.WriteLine("'''");
//{
//    SecurePublisher publisher = new SecurePublisher();
//    publisher.MyEvent += Handler1;
//    publisher.MyEvent += Handler2;

//    Console.WriteLine("\n이벤트 발생:");
//    publisher.RaiseEvent();

//    Console.WriteLine();
//    publisher.MyEvent -= Handler1;

//    Console.WriteLine("\n이벤트 발생:");
//    publisher.RaiseEvent();

//    static void Handler1(object sender, EventArgs e)
//    {
//        Console.WriteLine("Handler1 실행됨");
//    }
//    static void Handler2(object sender, EventArgs e)
//    {
//        Console.WriteLine("Handler2 실행됨");
//    }
//}
//Console.WriteLine("'''\n");

//Console.WriteLine("'''");
//{
//    Module1 m1 = new Module1();
//    Module1 m2 = new Module1();

//    GlobalNotifier.SendMessage("시스템 시작");
//    Console.WriteLine();
//    GlobalNotifier.SendMessage("데이터 로드 완료");
//}
//Console.WriteLine("'''\n");

//class Button
//{
//    public event EventHandler Click;
//    public void OnClick()
//    {
//        if(Click != null)
//        {
//            Click();
//        }
//    }
//}

//class Player
//{
//    public event Action<int> DamageTaken;
//    private int Health = 100;
//    public void TakeDamage(int damage)
//    {
//        Health -= damage;
//        Console.WriteLine($"플레이어 체력: {Health}");
//        DamageTaken?.Invoke(Health);
//    }
//}
//class HealthBar
//{
//    public void OnPlayerDamaged(int currentHealth)
//    {
//        Console.WriteLine($"[UI] 체력바 업데이트: {currentHealth}%");
//    }
//}
//class SoundManager
//{
//    public void OnPlayerDamaged(int currentHealth)
//    {
//        Console.WriteLine("[Sound] 피격 효과음 재생");
//    }
//}

//class Timer
//{
//    public event Action Tick;
//    public int count = 0;
//    public void Start()
//    {
//        for(int i = 0; i < 3; i++)
//        {
//            count++;
//            Console.WriteLine($"타이머: {count}초");
//            Tick?.Invoke();
//        }
//    }
//}
//class Logger
//{
//    public void OnTick()
//    {
//        Console.WriteLine("[Logger] 틱 기록됨");
//    }
//}

//class Sensor
//{
//    public event Action<string> Alter;

//    public void Detect(string message)
//    {
//        Console.WriteLine($"감지: {message}");
//        Alter?.Invoke(message);
//    }
//}

//class GameCharacter
//{
//    public event Action OnDeath;
//    public event Action<int> OnDamaged;
//    public event Action<int, string> OnAttack;

//    private int health = 100;
//    private string name;

//    public GameCharacter(string name)
//    {
//        this.name = name;
//    }
//    public void Damage(int damage)
//    {
//        health -= damage;
//        OnDamaged?.Invoke(health);
//        if (health <= 0)
//        {
//            OnDeath?.Invoke();
//        }
//    }
//    public void Attack(int attack, string name)
//    {
//        Console.WriteLine($"{name}에게 {attack} 데미지!");
//        OnAttack?.Invoke(attack, name);
//    }
//}

//class PriceChangedEventArgs : EventArgs
//{
//    public decimal OldPrice { get; }
//    public decimal NewPrice { get; }
//    public decimal ChangePercent { get; }

//    public PriceChangedEventArgs(decimal oldprice , decimal newprice)
//    {
//        OldPrice = oldprice;
//        NewPrice = newprice;
//        if(OldPrice != 0)
//        {
//            ChangePercent = (NewPrice - OldPrice)/oldprice * 100;
//        }
//    }
//}
//class Stock
//{
//    private string symbol;
//    private decimal price;

//    public EventHandler<PriceChangedEventArgs> PriceChanged;

//    public Stock(string symbol, decimal price)
//    {
//        this.symbol = symbol;
//        this.price = price;
//    }
//    public decimal Price
//    {
//        get => price;
//        set
//        {
//            if (price == value)
//            {
//                return;
//            }
//            decimal oldprice = price;
//            price = value;

//            OnPriceChanged(new PriceChangedEventArgs(oldprice, price));
//        }
//    }
//    protected virtual void OnPriceChanged(PriceChangedEventArgs e)
//    {
//        PriceChanged?.Invoke(this, e);
//    }

//    public override string ToString()
//    {
//        return $"{symbol}: {price:C}";
//    }
//}

//class FuelEventArgs : EventArgs
//{
//    public int Fuel { get; }
//    public string Warning { get; }

//    public FuelEventArgs(int fuel, string warning)
//    {
//        Fuel = fuel;
//        Warning = warning;
//    }
//}
//class Car
//{
//    private int fuel;
//    public event EventHandler<FuelEventArgs> FuelLow;
//    public event Action<int> FuelChanged;

//    public Car(int fuel)
//    {
//        this.fuel = fuel;
//    }
//    public void Drive()
//    {
//        if( fuel <= 0 )
//        {
//            Console.WriteLine("연료 없음! 운전 불가");
//            return;
//        }
//        fuel -= 10;
//        Console.WriteLine($"운전 중... 연료: {fuel}%");
//        FuelChanged?.Invoke(fuel);

//        if( fuel <= 0 )
//        {

//        }
//        else if( fuel <= 20 )
//        {

//        }
//    }
//    protected virtual void OnFuelLow(FuelEventArgs e)
//    {
//        FuelLow?.Invoke(this,e);
//    }
//}
//class Dashboard
//{
//    public void Subscribe(Car car)
//    {
//        car.FuelChanged += OnFuelChanged;
//        car.FuelLow += OnFuelLow;
//    }
//    public void Unsubscribe(Car car)
//    {
//        car.FuelChanged -= OnFuelChanged;
//        car.FuelLow -= OnFuelLow;
//    }

//    public void OnFuelChanged(int fuel)
//    {
//        string gauge = new string('█', fuel / 10);
//        Console.WriteLine($"[대시보드] 연료 게이지: {gauge}");
//    }
//    public void OnFuelLow(object sender, FuelEventArgs e)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine($"[경고!] {e.Warning} (잔량: {e.Fuel})");
//        Console.ResetColor();
//    }
//}

//class SecurePublisher
//{
//    private EventHandler _myEvent;
//    private readonly object _lock = new object();

//    public event EventHandler MyEvent
//    {
//        add
//        {
//            lock (_lock)
//            {
//                Console.WriteLine($"구독자 추가: {value.Method.Name}");
//                _myEvent += value;
//            }
//        }
//        remove
//        {
//            lock (_lock)
//            {
//                Console.WriteLine($"구독자 제거: {value.Method.Name}");
//                _myEvent -= value;
//            }
//        }
//    }

//    public void RaiseEvent()
//    {
//        _myEvent?.Invoke(this, EventArgs.Empty);
//    }
//}

//class GlobalNotifier
//{
//    public static event Action<string> OnGlobalMessage;
//    public static void SendMessage(string message)
//    {
//        Console.WriteLine($"[Global] 메시지 전송: {message}");
//        OnGlobalMessage?.Invoke(message);
//    }
    
//}
//class Module1
//{
//    public Module1()
//    {
//        GlobalNotifier.OnGlobalMessage += HandleMessage;
//    }
//    private void HandleMessage(string message)
//    {
//        Console.WriteLine($"[Module1] 수신: {message}");
//    }
//}
//class Module2
//{
//    public Module2()
//    {
//        GlobalNotifier.OnGlobalMessage += HandleMessage;
//    }
//    private void HandleMessage(string message)
//    {
//        Console.WriteLine($"[Module2] 수신: {message}");
//    }
//}