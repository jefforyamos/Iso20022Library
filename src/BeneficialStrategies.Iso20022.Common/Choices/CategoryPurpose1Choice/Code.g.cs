﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _THaa5dp-Ed-ak6NoX_4Aeg_1223014481.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.CategoryPurpose1Choice;

/// <summary>
/// Category purpose, as published in an external category purpose code list.
/// </summary>
public partial record Code : CategoryPurpose1Choice_
     , IIsoXmlSerilizable<Code>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies the category purpose, as published in an external category purpose code list.
    /// External code sets can be downloaded from www.iso20022.org.
    /// </summary>
    public required ExternalCategoryPurpose1Code Value { get; init; } 
    
    #nullable disable
    
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "Cd", xmlNamespace );
        writer.WriteValue(Value.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static new Code Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
