﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for GeneralCollateral.  ISO2002 ID# _BqvK8-oaEeadseq5W5YLvQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.RepurchaseAgreementType3Choice;

/// <summary>
/// Indicates that the repurchase agreement allows for the sale and repurchase of any of a selection of assets from a pool of eligible assets.
/// </summary>
public partial record GeneralCollateral : RepurchaseAgreementType3Choice_
     , IIsoXmlSerilizable<GeneralCollateral>
{
    #nullable enable
    
    /// <summary>
    /// ISINs of allocated securities of general collateral where known.
    /// </summary>
    public FinancialInstrument59? FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// List of eligible securities to be allocated where known.
    /// </summary>
    public IsoISINOct2015Identifier? EligibleFinancialInstrumentIdentification { get; init; } 
    
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
        if (FinancialInstrumentIdentification is FinancialInstrument59 FinancialInstrumentIdentificationValue)
        {
            writer.WriteStartElement(null, "FinInstrmId", xmlNamespace );
            FinancialInstrumentIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (EligibleFinancialInstrumentIdentification is IsoISINOct2015Identifier EligibleFinancialInstrumentIdentificationValue)
        {
            writer.WriteStartElement(null, "ElgblFinInstrmId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISINOct2015Identifier(EligibleFinancialInstrumentIdentificationValue)); // data type ISINOct2015Identifier System.String
            writer.WriteEndElement();
        }
    }
    public static new GeneralCollateral Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
