﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecurityDate22.  ISO2002 ID# _QUzDEV99Ee262vCSVgjImg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies security date details.
/// </summary>
public partial record SecurityDate22
     : IIsoXmlSerilizable<SecurityDate22>
{
    #nullable enable
    
    /// <summary>
    /// Date of the posting (credit or debit) to the account.
    /// </summary>
    public required IsoISODate PostingDate { get; init; } 
    /// <summary>
    /// Date/time at which securities become available for trading, for example first dealing date.
    /// </summary>
    public DateFormat41Choice_? AvailableDate { get; init; } 
    /// <summary>
    /// Date/time at which security will assimilate, become fungible, or have the same rights to dividends as the parent issue.
    /// </summary>
    public DateFormat41Choice_? PariPassuDate { get; init; } 
    /// <summary>
    /// Date/time at which a security will be entitled to a dividend.
    /// </summary>
    public DateFormat41Choice_? DividendRankingDate { get; init; } 
    /// <summary>
    /// Date/time at which a payment can be made, for example, if payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    public DateFormat41Choice_? EarliestPaymentDate { get; init; } 
    /// <summary>
    /// Date/time at which the movement is due to take place (cash and/or securities).
    /// </summary>
    public DateFormat41Choice_? PaymentDate { get; init; } 
    
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
        writer.WriteStartElement(null, "PstngDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(PostingDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        if (AvailableDate is DateFormat41Choice_ AvailableDateValue)
        {
            writer.WriteStartElement(null, "AvlblDt", xmlNamespace );
            AvailableDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PariPassuDate is DateFormat41Choice_ PariPassuDateValue)
        {
            writer.WriteStartElement(null, "PrpssDt", xmlNamespace );
            PariPassuDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DividendRankingDate is DateFormat41Choice_ DividendRankingDateValue)
        {
            writer.WriteStartElement(null, "DvddRnkgDt", xmlNamespace );
            DividendRankingDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (EarliestPaymentDate is DateFormat41Choice_ EarliestPaymentDateValue)
        {
            writer.WriteStartElement(null, "EarlstPmtDt", xmlNamespace );
            EarliestPaymentDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PaymentDate is DateFormat41Choice_ PaymentDateValue)
        {
            writer.WriteStartElement(null, "PmtDt", xmlNamespace );
            PaymentDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SecurityDate22 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
