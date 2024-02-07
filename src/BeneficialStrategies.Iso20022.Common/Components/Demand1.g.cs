﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Demand1.  ISO2002 ID# _-AylQnltEeG7BsjMvd1mEw_1908468693.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the demand.
/// </summary>
public partial record Demand1
     : IIsoXmlSerilizable<Demand1>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the presenting party to the demand.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Type of demand.
    /// </summary>
    public required DemandType1Code Type { get; init; } 
    /// <summary>
    /// Details related to the undertaking.
    /// </summary>
    public required Undertaking6 UndertakingIdentification { get; init; } 
    /// <summary>
    /// Details related to the demand amount.
    /// </summary>
    public required UndertakingAmount3 DemandAmount { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier assigned by the advising party to the undertaking.
    /// </summary>
    public IsoMax35Text? AdvisingPartyReferenceNumber { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier assigned by the second advising party to the undertaking.
    /// </summary>
    public IsoMax35Text? SecondAdvisingPartyReferenceNumber { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier assigned by the confirmer to the undertaking.
    /// </summary>
    public IsoMax35Text? ConfirmerReferenceNumber { get; init; } 
    /// <summary>
    /// Details related to the settlement account.
    /// </summary>
    public CashAccount27? SettlementAccount { get; init; } 
    /// <summary>
    /// Details of the beneficiary's presentation of documents.
    /// </summary>
    public Presentation2? PresentationDetails { get; init; } 
    /// <summary>
    /// Requested new expiry date as an alternative to payment of the demand.
    /// </summary>
    public IsoISODate? RequestedExpiryDate { get; init; } 
    /// <summary>
    /// Document(s) presented for examination.
    /// </summary>
    public DemandDocumentation1? DemandDocumentation { get; init; } 
    /// <summary>
    /// Additional information related to the demand.
    /// </summary>
    public SimpleValueList<IsoMax2000Text> AdditionalInformation { get; init; } = [];
    
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
        writer.WriteStartElement(null, "Id", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(Identification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Tp", xmlNamespace );
        writer.WriteValue(Type.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "UdrtkgId", xmlNamespace );
        UndertakingIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "DmndAmt", xmlNamespace );
        DemandAmount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AdvisingPartyReferenceNumber is IsoMax35Text AdvisingPartyReferenceNumberValue)
        {
            writer.WriteStartElement(null, "AdvsgPtyRefNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(AdvisingPartyReferenceNumberValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (SecondAdvisingPartyReferenceNumber is IsoMax35Text SecondAdvisingPartyReferenceNumberValue)
        {
            writer.WriteStartElement(null, "ScndAdvsgPtyRefNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(SecondAdvisingPartyReferenceNumberValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ConfirmerReferenceNumber is IsoMax35Text ConfirmerReferenceNumberValue)
        {
            writer.WriteStartElement(null, "CnfrmrRefNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ConfirmerReferenceNumberValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (SettlementAccount is CashAccount27 SettlementAccountValue)
        {
            writer.WriteStartElement(null, "SttlmAcct", xmlNamespace );
            SettlementAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PresentationDetails is Presentation2 PresentationDetailsValue)
        {
            writer.WriteStartElement(null, "PresntnDtls", xmlNamespace );
            PresentationDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RequestedExpiryDate is IsoISODate RequestedExpiryDateValue)
        {
            writer.WriteStartElement(null, "ReqdXpryDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(RequestedExpiryDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (DemandDocumentation is DemandDocumentation1 DemandDocumentationValue)
        {
            writer.WriteStartElement(null, "DmndDcmnttn", xmlNamespace );
            DemandDocumentationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
        AdditionalInformation.Serialize(writer, xmlNamespace, "Max2000Text", SerializationFormatter.IsoMax2000Text );
        writer.WriteEndElement();
    }
    public static Demand1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
