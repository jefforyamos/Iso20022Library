﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReceiveInformation12.  ISO2002 ID# _gCxroRYBEeOBE-jZfcm4KQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters applied to the settlement of a security transfer.
/// </summary>
public partial record ReceiveInformation12
     : IIsoXmlSerilizable<ReceiveInformation12>
{
    #nullable enable
    
    /// <summary>
    /// Date and time at which the securities are to be exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    public IsoISODate? RequestedSettlementDate { get; init; } 
    /// <summary>
    /// Date and time at which the securities were exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    public DateAndDateTimeChoice_? EffectiveSettlementDate { get; init; } 
    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    public IsoActiveCurrencyAndAmount? SettlementAmount { get; init; } 
    /// <summary>
    /// Indicates whether the settlement amount includes the stamp duty amount.
    /// </summary>
    public StampDutyType2Code? StampDuty { get; init; } 
    /// <summary>
    /// Deal amount.
    /// </summary>
    public IsoActiveCurrencyAndAmount? NetAmount { get; init; } 
    /// <summary>
    /// Charge related to the transfer of a financial instrument.
    /// </summary>
    public Charge20? ChargeDetails { get; init; } 
    /// <summary>
    /// Commission related to the transfer of a financial instrument.
    /// </summary>
    public Commission17? CommissionDetails { get; init; } 
    /// <summary>
    /// Tax related to the transfer of a financial instrument.
    /// </summary>
    public Tax21? TaxDetails { get; init; } 
    /// <summary>
    /// Specifies foreign exchange details applied to the payment of charges, taxes and commissions as a result of the transfer.
    /// </summary>
    public ForeignExchangeTerms7? ForeignExchangeDetails { get; init; } 
    /// <summary>
    /// Chain of parties involved in the settlement of a transaction.
    /// </summary>
    public ReceivingPartiesAndAccount9? SettlementPartiesDetails { get; init; } 
    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    public PhysicalTransferType1Code? PhysicalTransfer { get; init; } 
    /// <summary>
    /// Parameters of a physical delivery.
    /// </summary>
    public DeliveryParameters4? PhysicalTransferDetails { get; init; } 
    /// <summary>
    /// Unique and unambiguous investor's identification of a transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    public IsoMax35Text? ClientReference { get; init; } 
    
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
        if (RequestedSettlementDate is IsoISODate RequestedSettlementDateValue)
        {
            writer.WriteStartElement(null, "ReqdSttlmDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(RequestedSettlementDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (EffectiveSettlementDate is DateAndDateTimeChoice_ EffectiveSettlementDateValue)
        {
            writer.WriteStartElement(null, "FctvSttlmDt", xmlNamespace );
            EffectiveSettlementDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlementAmount is IsoActiveCurrencyAndAmount SettlementAmountValue)
        {
            writer.WriteStartElement(null, "SttlmAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(SettlementAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (StampDuty is StampDutyType2Code StampDutyValue)
        {
            writer.WriteStartElement(null, "StmpDty", xmlNamespace );
            writer.WriteValue(StampDutyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (NetAmount is IsoActiveCurrencyAndAmount NetAmountValue)
        {
            writer.WriteStartElement(null, "NetAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(NetAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (ChargeDetails is Charge20 ChargeDetailsValue)
        {
            writer.WriteStartElement(null, "ChrgDtls", xmlNamespace );
            ChargeDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CommissionDetails is Commission17 CommissionDetailsValue)
        {
            writer.WriteStartElement(null, "ComssnDtls", xmlNamespace );
            CommissionDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TaxDetails is Tax21 TaxDetailsValue)
        {
            writer.WriteStartElement(null, "TaxDtls", xmlNamespace );
            TaxDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ForeignExchangeDetails is ForeignExchangeTerms7 ForeignExchangeDetailsValue)
        {
            writer.WriteStartElement(null, "FXDtls", xmlNamespace );
            ForeignExchangeDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlementPartiesDetails is ReceivingPartiesAndAccount9 SettlementPartiesDetailsValue)
        {
            writer.WriteStartElement(null, "SttlmPtiesDtls", xmlNamespace );
            SettlementPartiesDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PhysicalTransfer is PhysicalTransferType1Code PhysicalTransferValue)
        {
            writer.WriteStartElement(null, "PhysTrf", xmlNamespace );
            writer.WriteValue(PhysicalTransferValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (PhysicalTransferDetails is DeliveryParameters4 PhysicalTransferDetailsValue)
        {
            writer.WriteStartElement(null, "PhysTrfDtls", xmlNamespace );
            PhysicalTransferDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ClientReference is IsoMax35Text ClientReferenceValue)
        {
            writer.WriteStartElement(null, "ClntRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ClientReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static ReceiveInformation12 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
