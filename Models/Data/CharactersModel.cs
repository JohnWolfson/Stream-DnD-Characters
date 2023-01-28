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
public partial class CharacterData
{

    private CharacterDataCharacters[] charactersField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Characters")]
    public CharacterDataCharacters[] Characters
    {
        get
        {
            return this.charactersField;
        }
        set
        {
            this.charactersField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class CharacterDataCharacters
{

    private string idField;

    private string nameField;

    private string raceField;

    private string classField;

    private CharacterDataCharactersHP hpField;

    private byte acField;

    /// <remarks/>
    public string ID
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

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
    public string Race
    {
        get
        {
            return this.raceField;
        }
        set
        {
            this.raceField = value;
        }
    }

    /// <remarks/>
    public string Class
    {
        get
        {
            return this.classField;
        }
        set
        {
            this.classField = value;
        }
    }

    /// <remarks/>
    public CharacterDataCharactersHP HP
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

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class CharacterDataCharactersHP
{

    private byte currentField;

    private byte maxField;

    /// <remarks/>
    public byte Current
    {
        get
        {
            return this.currentField;
        }
        set
        {
            this.currentField = value;
        }
    }

    /// <remarks/>
    public byte Max
    {
        get
        {
            return this.maxField;
        }
        set
        {
            this.maxField = value;
        }
    }
}

