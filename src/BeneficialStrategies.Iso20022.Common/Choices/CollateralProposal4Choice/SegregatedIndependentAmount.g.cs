﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SegregatedIndependentAmount.  ISO2002 ID# _xv7544FvEeWtPe6Crjmeug.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.CollateralProposal4Choice;

/// <summary>
/// Provides details about the proposal for the segregated independent amount.
/// </summary>
public partial record SegregatedIndependentAmount : CollateralProposal4Choice_
     , IIsoXmlSerilizable<SegregatedIndependentAmount>
{
    #nullable enable
    
    /// <summary>
    /// Provides the call amount that is agreed and that will result in a collateral movement.
    /// </summary>
    public required IsoActiveCurrencyAndAmount AgreedAmount { get; init; } 
    /// <summary>
    /// Provides the collateral movement direction that is a delivery and optionaly a return, or a return only.
    /// </summary>
    public CollateralMovement4Choice_? MovementDirection { get; init; } 
    
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
        writer.WriteStartElement(null, "AgrdAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(AgreedAmount)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        if (MovementDirection is CollateralMovement4Choice_ MovementDirectionValue)
        {
            writer.WriteStartElement(null, "MvmntDrctn", xmlNamespace );
            MovementDirectionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new SegregatedIndependentAmount Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
