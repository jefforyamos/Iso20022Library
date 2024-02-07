﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SouthAfricanNCCIdentification.  ISO2002 ID# _TDF7lNp-Ed-ak6NoX_4Aeg_1990860839.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification2Choice;

/// <summary>
/// South African National Clearing Code (NCC) - identifies South African financial institutions on the South African national clearing system. The code is assigned by the South African Bankers Services Company Ltd. (BankServ).
/// </summary>
public partial record SouthAfricanNCCIdentification : ClearingSystemMemberIdentification2Choice_
     , IIsoXmlSerilizable<SouthAfricanNCCIdentification>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// South African National Clearing Code (NCC). Identifies South African financial institutions on the South African national clearing system. The code is assigned by the South African Bankers Services Company Ltd. (BankServ).
    /// </summary>
    public required IsoSouthAfricanNCCIdentifier Value { get; init; } 
    
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
        writer.WriteStartElement(null, "ZANCC", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoSouthAfricanNCCIdentifier(Value)); // data type SouthAfricanNCCIdentifier System.String
        writer.WriteEndElement();
    }
    public static new SouthAfricanNCCIdentification Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
