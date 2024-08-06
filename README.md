# Design Patterns Example Project

Bu proje, Singleton, Factory, Abstraction, Builder ve Prototype patternlerini açıklayan ve örnekleyen bir C# uygulamasıdır. Her pattern için ayrı dosyalar ve örnek kodlar bulunmaktadır.

## Design Patterns

### Singleton Pattern
Singleton pattern, bir sınıfın yalnızca bir örneğe sahip olmasını sağlar ve bu örneğe evrensel bir erişim noktası sağlar.
- **[SingletonExample.cs](Singleton/SingletonExample.cs)**

### Factory Pattern
Factory pattern, nesne oluşturma işlemini alt sınıflara bırakır. Bu sayede nesne oluşturma sürecini soyutlar ve kodun esnekliğini artırır.
- **[FactoryExample.cs](Factory/FactoryExample.cs)**

### Abstraction Pattern
Abstraction pattern, kullanıcıların soyut sınıflar veya arayüzler üzerinden sınıflarla etkileşime geçmesini sağlar. Bu, implementasyon detaylarını gizler ve esnekliği artırır.
- **[AbstractionExample.cs](Abstraction/AbstractionExample.cs)**

### Builder Pattern
Builder pattern, karmaşık nesnelerin adım adım oluşturulmasını sağlar. Nesne oluşturma sürecini kontrol eder ve farklı temsilcilerle aynı oluşturma sürecini kullanarak farklı türde nesneler oluşturabilir.
- **[BuilderExample.cs](Builder/BuilderExample.cs)**

### Prototype Pattern
Prototype pattern, bir nesnenin mevcut bir örneğini kopyalayarak yeni nesneler oluşturur. Bu, nesnelerin bir şablon gibi kullanılmasını sağlar ve aynı türden nesneleri hızlı bir şekilde oluşturur.
- **[PrototypeExample.cs](Prototype/PrototypeExample.cs)**
