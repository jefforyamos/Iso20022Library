﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IndianFinancialSystemCode.  ISO2002 ID# _TDPFgtp-Ed-ak6NoX_4Aeg_2074902177.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification2Choice;

/// <summary>
/// Indian Financial System Code - identifies Indian financial institutions on the Indian local clearing system.
/// </summary>
public partial record IndianFinancialSystemCode : ClearingSystemMemberIdentification2Choice_
     , IIsoXmlSerilizable<IndianFinancialSystemCode>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Indian Financial System Code Identifier. Identifies Indian financial institutions on the Indian national clearing system.
    /// </summary>
    public required IsoIndianFinancialSystemCodeIdentifier Value { get; init; } 
    
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
        writer.WriteStartElement(null, "INIFSC", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoIndianFinancialSystemCodeIdentifier(Value)); // data type IndianFinancialSystemCodeIdentifier System.String
        writer.WriteEndElement();
    }
    public static new IndianFinancialSystemCode Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
