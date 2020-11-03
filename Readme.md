# FRESH FRUIT

Fresh Fruit merupakan sebuah aplikasi yang digunakan untuk menambahkan buah-buahan kedalam keranjang, serta menampilkan gambar/icon . Pada Aplikasi ini juga terdapat konsep MVC (Model View Controller).

# SCOPE & FUNCTIONALITIES

- User dapat menekan tombol Add untuk menambahkan buah/fruit
- User dapat menampilkan nama buah yang sudah di ADD kedalam keranjang (Listbox)
- User dapat menghapus nama uah yang sudah tampil dikeranjang (Listbox) dengan menekan tombol DELETE.

# HOW DOES IT WORKS?
Pada Method Fruit.cs itu merupakan Logic View yang digunakan untuk menampilkan nama buah pada listbox. berikut merupakan source codenya

``` csharp
 public string name { get; set; }

        public Fruit(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
```
logic model bisnis pada MainWindow.xaml.cs digunakan untuk menambahkan buah dengan cara menekan tombol ADD pada setiap gambar , dan menampilkannya pada listbox melalui method Fruit.cs. berikut merupakan source code pada MainWindow.xaml.cs

```csharp
        private void OnButtonAddAnggurClicked(object sender, RoutedEventArgs e)
        {
            Fruit anggur = new Fruit("Anggur");
            Apriyan.addFruit(anggur);

            ListBoxBucket.Items.Refresh();
        }

        private void OnButtonAddAppleClicked(object sender, RoutedEventArgs e)
        {
            Fruit Apple = new Fruit("Apple");
            Apriyan.addFruit(Apple);

            ListBoxBucket.Items.Refresh();
        }

        private void OnButtonAddBananaClicked(object sender, RoutedEventArgs e)
        {
            Fruit Banana = new Fruit("Banana");
            Apriyan.addFruit(Banana);

            ListBoxBucket.Items.Refresh();
        }

        private void OnButtonAddOrangeClicked(object sender, RoutedEventArgs e)
        {
            Fruit orange = new Fruit("orange");
            Apriyan.addFruit(orange);

            ListBoxBucket.Items.Refresh();
        }
```

# TERIMA KASIH :)