﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProprietaryCode.  ISO2002 ID# _RIcz1tp-Ed-ak6NoX_4Aeg_-1267403815.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.ChargeTypeChoice;

/// <summary>
/// Type of charge is a bilaterally agreed code.
/// </summary>
public partial record ProprietaryCode : ChargeTypeChoice_
     , IIsoXmlSerilizable<ProprietaryCode>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies an alphanumeric string with a maximum length of 4 characters.
    /// </summary>
    public required IsoMax4AlphaNumericText Value { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "PrtryCd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax4AlphaNumericText(Value)); // data type Max4AlphaNumericText System.String
        writer.WriteEndElement();
    }
    public static new ProprietaryCode Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
