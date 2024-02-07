﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PriceCorrection3.  ISO2002 ID# _RLuxVdp-Ed-ak6NoX_4Aeg_993416543.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Original and corrected price information of an investment fund.
/// </summary>
public partial record PriceCorrection3
     : IIsoXmlSerilizable<PriceCorrection3>
{
    #nullable enable
    
    /// <summary>
    /// Information related to the price valuation of a financial instrument sent in a previous price report.
    /// </summary>
    public required PriceValuation3 PreviouslySentPriceDetails { get; init; } 
    /// <summary>
    /// Information related to the new price valuation of a financial instrument, which overrides previously sent information.
    /// </summary>
    public PriceValuation3? CorrectedPriceDetails { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public Extension1? Extension { get; init; } 
    
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
        writer.WriteStartElement(null, "PrevslySntPricDtls", xmlNamespace );
        PreviouslySentPriceDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (CorrectedPriceDetails is PriceValuation3 CorrectedPriceDetailsValue)
        {
            writer.WriteStartElement(null, "CrrctdPricDtls", xmlNamespace );
            CorrectedPriceDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Extension is Extension1 ExtensionValue)
        {
            writer.WriteStartElement(null, "Xtnsn", xmlNamespace );
            ExtensionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PriceCorrection3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
