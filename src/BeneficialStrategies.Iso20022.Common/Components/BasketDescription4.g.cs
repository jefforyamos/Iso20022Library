﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BasketDescription4.  ISO2002 ID# _FYAbAZ3EEeuwmdq0KtnICg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the constituents of the basket.
/// </summary>
public partial record BasketDescription4
     : IIsoXmlSerilizable<BasketDescription4>
{
    #nullable enable
    
    /// <summary>
    /// International Securities Identification Number (ISIN). A numbering system designed by the United Nation's International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
    /// </summary>
    public IsoISIN2021Identifier? ISIN { get; init; } 
    /// <summary>
    /// Index on which the financial instrument is based.
    /// </summary>
    public FinancialInstrument98? Index { get; init; } 
    
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
        if (ISIN is IsoISIN2021Identifier ISINValue)
        {
            writer.WriteStartElement(null, "ISIN", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISIN2021Identifier(ISINValue)); // data type ISIN2021Identifier System.String
            writer.WriteEndElement();
        }
        if (Index is FinancialInstrument98 IndexValue)
        {
            writer.WriteStartElement(null, "Indx", xmlNamespace );
            IndexValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static BasketDescription4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
