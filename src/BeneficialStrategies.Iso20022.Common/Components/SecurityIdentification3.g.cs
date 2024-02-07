﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecurityIdentification3.  ISO2002 ID# _QdiOk9p-Ed-ak6NoX_4Aeg_2006961788.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a security by its symbol.
/// </summary>
public partial record SecurityIdentification3
     : IIsoXmlSerilizable<SecurityIdentification3>
{
    #nullable enable
    
    /// <summary>
    /// International Securities Identification Number (ISIN). A numbering system designed by the United Nation's International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
    /// </summary>
    public required IsoISINIdentifier ISIN { get; init; } 
    /// <summary>
    /// Letters that identify a stock traded on a stock exchange. The Ticker Symbol is a short and convenient way of identifying a stock, eg, RTR.L for Reuters quoted in London.
    /// </summary>
    public IsoTickerIdentifier? TickerSymbol { get; init; } 
    /// <summary>
    /// Committee on Uniform Securities and Identification Procedures (CUSIP). The standards body that created and maintains the securities classification system in the US. The CUSIP is composed of a 9-character number that uniquely identifies a particular security. Non-US securities have a similar number called the CINS number.
    /// </summary>
    public IsoCUSIPIdentifier? CUSIP { get; init; } 
    /// <summary>
    /// Stock Exchange Daily Official List (SEDOL) number. A code used by the London Stock Exchange to identify foreign stocks, especially those that aren't actively traded in the US and don't have a CUSIP number.
    /// </summary>
    public IsoSEDOLIdentifier? SEDOL { get; init; } 
    /// <summary>
    /// Identifier of a security assigned by the Japanese QUICK identification scheme for financial instruments.
    /// </summary>
    public IsoQUICKIdentifier? QUICK { get; init; } 
    /// <summary>
    /// Proprietary identification of a security assigned by an institution or organisation.
    /// </summary>
    public AlternateFinancialInstrumentIdentification1? OtherIdentification { get; init; } 
    
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
        writer.WriteStartElement(null, "ISIN", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISINIdentifier(ISIN)); // data type ISINIdentifier System.String
        writer.WriteEndElement();
        if (TickerSymbol is IsoTickerIdentifier TickerSymbolValue)
        {
            writer.WriteStartElement(null, "TckrSymb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTickerIdentifier(TickerSymbolValue)); // data type TickerIdentifier System.String
            writer.WriteEndElement();
        }
        if (CUSIP is IsoCUSIPIdentifier CUSIPValue)
        {
            writer.WriteStartElement(null, "CUSIP", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoCUSIPIdentifier(CUSIPValue)); // data type CUSIPIdentifier System.String
            writer.WriteEndElement();
        }
        if (SEDOL is IsoSEDOLIdentifier SEDOLValue)
        {
            writer.WriteStartElement(null, "SEDOL", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoSEDOLIdentifier(SEDOLValue)); // data type SEDOLIdentifier System.String
            writer.WriteEndElement();
        }
        if (QUICK is IsoQUICKIdentifier QUICKValue)
        {
            writer.WriteStartElement(null, "QUICK", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoQUICKIdentifier(QUICKValue)); // data type QUICKIdentifier System.String
            writer.WriteEndElement();
        }
        if (OtherIdentification is AlternateFinancialInstrumentIdentification1 OtherIdentificationValue)
        {
            writer.WriteStartElement(null, "OthrId", xmlNamespace );
            OtherIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SecurityIdentification3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
