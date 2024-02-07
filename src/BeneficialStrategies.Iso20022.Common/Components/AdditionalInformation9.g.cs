﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdditionalInformation9.  ISO2002 ID# _YoyEkSzREeOsiuMH68so7Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional specific modification criteria.
/// </summary>
public partial record AdditionalInformation9
     : IIsoXmlSerilizable<AdditionalInformation9>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction as known by the account owner. Will be used in a unilateral split to provide the executing party with the account owner identification of each split transaction.
    /// </summary>
    public IsoMax35Text? AccountOwnerTransactionIdentification { get; init; } 
    /// <summary>
    /// Type of instrument involved in the transactions on which the modification request should apply.
    /// </summary>
    public ClassificationType1Choice_? ClassificationType { get; init; } 
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    public SecuritiesAccount13? SafekeepingAccount { get; init; } 
    /// <summary>
    /// Identification of the financial instrument involved in the transactions on which the modification request should apply.
    /// </summary>
    public SecurityIdentification14? FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Quantity of financial instrument concerned by the settlement condition modification request.
    /// </summary>
    public FinancialInstrumentQuantity1Choice_? Quantity { get; init; } 
    /// <summary>
    /// Date/time when the request should take effect.
    /// </summary>
    public DateAndDateTimeChoice_? EffectiveDate { get; init; } 
    /// <summary>
    /// Date/time when the request should cease to be in effect.
    /// </summary>
    public DateAndDateTimeChoice_? ExpiryDate { get; init; } 
    /// <summary>
    /// Date/time of the release.
    /// </summary>
    public DateAndDateTimeChoice_? CutOffDate { get; init; } 
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    public PartyIdentification43Choice_? Investor { get; init; } 
    /// <summary>
    /// Party that, in a settlement chain interacts with the depository.
    /// </summary>
    public PartyIdentificationAndAccount43? DeliveringParty1 { get; init; } 
    /// <summary>
    /// Party that, in a settlement chain interacts with the depository.
    /// </summary>
    public PartyIdentificationAndAccount43? ReceivingParty1 { get; init; } 
    /// <summary>
    /// Provides details on the processing status of the transaction.
    /// </summary>
    public ProcessingStatus39Choice_? ProcessingStatus { get; init; } 
    
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
        if (AccountOwnerTransactionIdentification is IsoMax35Text AccountOwnerTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "AcctOwnrTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(AccountOwnerTransactionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ClassificationType is ClassificationType1Choice_ ClassificationTypeValue)
        {
            writer.WriteStartElement(null, "ClssfctnTp", xmlNamespace );
            ClassificationTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SafekeepingAccount is SecuritiesAccount13 SafekeepingAccountValue)
        {
            writer.WriteStartElement(null, "SfkpgAcct", xmlNamespace );
            SafekeepingAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FinancialInstrumentIdentification is SecurityIdentification14 FinancialInstrumentIdentificationValue)
        {
            writer.WriteStartElement(null, "FinInstrmId", xmlNamespace );
            FinancialInstrumentIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Quantity is FinancialInstrumentQuantity1Choice_ QuantityValue)
        {
            writer.WriteStartElement(null, "Qty", xmlNamespace );
            QuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (EffectiveDate is DateAndDateTimeChoice_ EffectiveDateValue)
        {
            writer.WriteStartElement(null, "FctvDt", xmlNamespace );
            EffectiveDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ExpiryDate is DateAndDateTimeChoice_ ExpiryDateValue)
        {
            writer.WriteStartElement(null, "XpryDt", xmlNamespace );
            ExpiryDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CutOffDate is DateAndDateTimeChoice_ CutOffDateValue)
        {
            writer.WriteStartElement(null, "CutOffDt", xmlNamespace );
            CutOffDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Investor is PartyIdentification43Choice_ InvestorValue)
        {
            writer.WriteStartElement(null, "Invstr", xmlNamespace );
            InvestorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DeliveringParty1 is PartyIdentificationAndAccount43 DeliveringParty1Value)
        {
            writer.WriteStartElement(null, "DlvrgPty1", xmlNamespace );
            DeliveringParty1Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReceivingParty1 is PartyIdentificationAndAccount43 ReceivingParty1Value)
        {
            writer.WriteStartElement(null, "RcvgPty1", xmlNamespace );
            ReceivingParty1Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ProcessingStatus is ProcessingStatus39Choice_ ProcessingStatusValue)
        {
            writer.WriteStartElement(null, "PrcgSts", xmlNamespace );
            ProcessingStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AdditionalInformation9 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
