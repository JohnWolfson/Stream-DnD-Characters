/*****************************************************************************************************************************

The code in this file was generated using the XML in Resources/DemoCharacter.xml, any changes should be done by editting the
XML in that file and regenerating the code from that XML

*****************************************************************************************************************************/

// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class Characters
{

    private CharactersCharacter characterField;

    /// <remarks/>
    public CharactersCharacter Character
    {
        get
        {
            return this.characterField;
        }
        set
        {
            this.characterField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class CharactersCharacter
{

    private string nameField;

    private byte hpField;

    private byte acField;

    /// <remarks/>
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public byte HP
    {
        get
        {
            return this.hpField;
        }
        set
        {
            this.hpField = value;
        }
    }

    /// <remarks/>
    public byte AC
    {
        get
        {
            return this.acField;
        }
        set
        {
            this.acField = value;
        }
    }
}

