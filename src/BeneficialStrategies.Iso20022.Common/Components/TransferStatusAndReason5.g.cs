﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransferStatusAndReason5.  ISO2002 ID# _FjDpwYfuEeevKP8c-ilVhA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the status of a transfer instruction and its reason.
/// </summary>
public partial record TransferStatusAndReason5
     : IIsoXmlSerilizable<TransferStatusAndReason5>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    public IsoMax35Text? MasterReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification of the transfer, as assigned by the instructing party.
    /// </summary>
    public required IsoMax35Text TransferReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous investor's identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    public AdditionalReference7? ClientReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
    /// </summary>
    public IsoMax35Text? CancellationReference { get; init; } 
    /// <summary>
    /// Status of the transfer instruction.
    /// </summary>
    public required TransferStatus2Choice_ TransferStatus { get; init; } 
    /// <summary>
    /// Date and time at which the transfer was executed.
    /// </summary>
    public IsoISODate? TradeDate { get; init; } 
    /// <summary>
    /// Date on which the document, for example, the application form, was sent.
    /// </summary>
    public IsoISODate? SendOutDate { get; init; } 
    /// <summary>
    /// Number of units to be transferred.
    /// </summary>
    public IsoDecimalNumber? TotalUnitsNumber { get; init; } 
    /// <summary>
    /// Weighted average price of the units in the account. The AveragePrice may also be known as the average acquisition price.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAnd13DecimalAmount? AveragePrice { get; init; } 
    /// <summary>
    /// Breakdown of units to be transferred.
    /// </summary>
    public Unit8? UnitsDetails { get; init; } 
    /// <summary>
    /// Party that initiates the status.
    /// </summary>
    public PartyIdentification113? StatusInitiator { get; init; } 
    
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
        if (MasterReference is IsoMax35Text MasterReferenceValue)
        {
            writer.WriteStartElement(null, "MstrRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(MasterReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TrfRef", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(TransferReference)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (ClientReference is AdditionalReference7 ClientReferenceValue)
        {
            writer.WriteStartElement(null, "ClntRef", xmlNamespace );
            ClientReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CancellationReference is IsoMax35Text CancellationReferenceValue)
        {
            writer.WriteStartElement(null, "CxlRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CancellationReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TrfSts", xmlNamespace );
        TransferStatus.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (TradeDate is IsoISODate TradeDateValue)
        {
            writer.WriteStartElement(null, "TradDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(TradeDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (SendOutDate is IsoISODate SendOutDateValue)
        {
            writer.WriteStartElement(null, "SndOutDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(SendOutDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (TotalUnitsNumber is IsoDecimalNumber TotalUnitsNumberValue)
        {
            writer.WriteStartElement(null, "TtlUnitsNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoDecimalNumber(TotalUnitsNumberValue)); // data type DecimalNumber System.UInt64
            writer.WriteEndElement();
        }
        if (AveragePrice is IsoActiveOrHistoricCurrencyAnd13DecimalAmount AveragePriceValue)
        {
            writer.WriteStartElement(null, "AvrgPric", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAnd13DecimalAmount(AveragePriceValue)); // data type ActiveOrHistoricCurrencyAnd13DecimalAmount System.Decimal
            writer.WriteEndElement();
        }
        if (UnitsDetails is Unit8 UnitsDetailsValue)
        {
            writer.WriteStartElement(null, "UnitsDtls", xmlNamespace );
            UnitsDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (StatusInitiator is PartyIdentification113 StatusInitiatorValue)
        {
            writer.WriteStartElement(null, "StsInitr", xmlNamespace );
            StatusInitiatorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static TransferStatusAndReason5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
