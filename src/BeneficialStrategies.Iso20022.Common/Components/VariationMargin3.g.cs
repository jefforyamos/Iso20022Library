﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for VariationMargin3.  ISO2002 ID# _-eWgAKMOEeCojJW5vEuTEQ_-52349864.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Margin required to cover the risk because of the price fluctuations occurred on the unsettled exposures towards central counterparty.
/// </summary>
public partial record VariationMargin3
     : IIsoXmlSerilizable<VariationMargin3>
{
    #nullable enable
    
    /// <summary>
    /// Provides details about the security identification.
    /// </summary>
    public SecurityIdentification14? FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Margin required to cover the risk because of the price fluctuations occurred on the unsettled exposures towards the central counterparty.
    /// </summary>
    public TotalVariationMargin1? TotalVariationMargin { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _-eWgAqMOEeCojJW5vEuTEQ_-166188930
    /// <summary>
    /// Net unrealised profit or loss on the value of the netted, gross and failing positions.
    /// </summary>
    public required Amount2 TotalMarkToMarket { get; init; } 
    /// <summary>
    /// Unrealised net loss calculated at the participant portfolio level.
    /// </summary>
    public Amount2? MarkToMarketNetted { get; init; } 
    /// <summary>
    /// Unrealised net loss calculated in that market/boundary.
    /// </summary>
    public Amount2? MarkToMarketGross { get; init; } 
    /// <summary>
    /// Sum of the unrealised loss without taking profit into consideration.
    /// </summary>
    public Amount2? MarkToMarketFails { get; init; } 
    /// <summary>
    /// Haircut applied to the absolute value of the participants net positions. Calculation depends on a participants credit rating.
    /// </summary>
    public Amount2? FailsHaircut { get; init; } 
    
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
        if (FinancialInstrumentIdentification is SecurityIdentification14 FinancialInstrumentIdentificationValue)
        {
            writer.WriteStartElement(null, "FinInstrmId", xmlNamespace );
            FinancialInstrumentIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        // Not sure how to serialize TotalVariationMargin, multiplicity Unknown
        writer.WriteStartElement(null, "TtlMrkToMkt", xmlNamespace );
        TotalMarkToMarket.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (MarkToMarketNetted is Amount2 MarkToMarketNettedValue)
        {
            writer.WriteStartElement(null, "MrkToMktNetd", xmlNamespace );
            MarkToMarketNettedValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MarkToMarketGross is Amount2 MarkToMarketGrossValue)
        {
            writer.WriteStartElement(null, "MrkToMktGrss", xmlNamespace );
            MarkToMarketGrossValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MarkToMarketFails is Amount2 MarkToMarketFailsValue)
        {
            writer.WriteStartElement(null, "MrkToMktFls", xmlNamespace );
            MarkToMarketFailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FailsHaircut is Amount2 FailsHaircutValue)
        {
            writer.WriteStartElement(null, "FlsHrcut", xmlNamespace );
            FailsHaircutValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static VariationMargin3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
