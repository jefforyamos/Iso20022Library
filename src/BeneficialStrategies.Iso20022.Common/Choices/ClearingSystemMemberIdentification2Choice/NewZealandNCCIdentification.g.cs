﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NewZealandNCCIdentification.  ISO2002 ID# _TC8KkNp-Ed-ak6NoX_4Aeg_1989939487.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification2Choice;

/// <summary>
/// New Zealand Bank/Branch Code - identifies New Zealand institutions on the New Zealand national clearing system. The code is assigned by the New Zealand Bankers' Association (NZBA).
/// </summary>
public partial record NewZealandNCCIdentification : ClearingSystemMemberIdentification2Choice_
     , IIsoXmlSerilizable<NewZealandNCCIdentification>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// New Zealand Bank/Branch Code. Identifies New Zealand institutions on the New Zealand national clearing system. The code is assigned by the New Zealand Bankers' Association (NZBA).
    /// </summary>
    public required IsoNewZealandNCCIdentifier Value { get; init; } 
    
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
        writer.WriteStartElement(null, "NZNCC", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoNewZealandNCCIdentifier(Value)); // data type NewZealandNCCIdentifier System.String
        writer.WriteEndElement();
    }
    public static new NewZealandNCCIdentification Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
