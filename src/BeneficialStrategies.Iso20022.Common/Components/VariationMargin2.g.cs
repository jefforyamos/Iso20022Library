﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for VariationMargin2.  ISO2002 ID# _Uk2CN9p-Ed-ak6NoX_4Aeg_1785473393.
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
public partial record VariationMargin2
     : IIsoXmlSerilizable<VariationMargin2>
{
    #nullable enable
    
    /// <summary>
    /// Margin required to cover the risk because of the price fluctuations occurred on the unsettled exposures towards the central counterparty.
    /// </summary>
    public TotalVariationMargin1? TotalVariationMargin { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _Uk2CONp-Ed-ak6NoX_4Aeg_-292711042
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
    public required Amount2 FailsHaircut { get; init; } 
    
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
        writer.WriteStartElement(null, "FlsHrcut", xmlNamespace );
        FailsHaircut.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static VariationMargin2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
