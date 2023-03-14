using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cats__2023
{
    public Cat_2023(string name, string furColor, int age, int lives)
    {
        Name = name;
        FurColor = furColor;
        Age = Age;
        Lives = lives;
    }
    private string name;
    private string furColor;
    private int age;
    private int lives;

    public string Name
    {
        get { return this.name; } //return the value
        set { this.name = value; } //sets the value
    }
    public string FurColor
    {
        get { return this.furColor; }
        set { this.furColor = value; }
    }
    public string Age
    {
        get { return this.age; }
        set { this.age = value; }
    }
    public int Lives
    {
        get { return this.lives; }
        set { this.lives = value; }
    }

}
}
    {
    }
}
