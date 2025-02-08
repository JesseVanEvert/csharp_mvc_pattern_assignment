
using Controller;
using Model;
using View;

ProductModel model = new();
ProductView view = new();
ProductController controller = new(model, view);

view.ShowMenu();

while(true)
{
    controller.ProcessUserInput(
    int.Parse(
        Console.ReadLine()
        )
    );

    System.Threading.Thread.Sleep(1000);
}


