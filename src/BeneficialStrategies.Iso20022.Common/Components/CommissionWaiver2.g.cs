﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CommissionWaiver2.  ISO2002 ID# _VRshJdp-Ed-ak6NoX_4Aeg_998746205.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Non-enforcement of the right to all or part of a commission by the party entitled to the commission.
/// </summary>
public partial record CommissionWaiver2
     : IIsoXmlSerilizable<CommissionWaiver2>
{
    #nullable enable
    
    /// <summary>
    /// Form of the rebate, eg, cash.
    /// </summary>
    public required WaivingType1 InstructionBasis { get; init; } 
    /// <summary>
    /// Proportion of the commission that is waived, ie, if the commission is 5% and half is waived, 2.5% should be stated in this field.
    /// </summary>
    public required IsoPercentageRate WaivedRate { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "InstrBsis", xmlNamespace );
        InstructionBasis.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "WvdRate", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoPercentageRate(WaivedRate)); // data type PercentageRate System.Decimal
        writer.WriteEndElement();
    }
    public static CommissionWaiver2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
