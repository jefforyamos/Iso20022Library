﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IntraPositionDetails42.  ISO2002 ID# _JbXezZwvEeazcsnODTksnQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the intra-position movement.
/// </summary>
public partial record IntraPositionDetails42
     : IIsoXmlSerilizable<IntraPositionDetails42>
{
    #nullable enable
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    public IsoRestrictedFINXMax16Text? PoolIdentification { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public PartyIdentification103Choice_? AccountOwner { get; init; } 
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    public required SecuritiesAccount30 SafekeepingAccount { get; init; } 
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    public required FinancialInstrumentQuantity1Choice_ SettlementQuantity { get; init; } 
    /// <summary>
    /// Number identifying a lot constituting the financial instrument.
    /// </summary>
    public GenericIdentification39? LotNumber { get; init; } 
    /// <summary>
    /// Date and time at which the securities are to be moved.
    /// </summary>
    public required DateAndDateTimeChoice_ SettlementDate { get; init; } 
    /// <summary>
    /// Time stamp on when the transaction is acknowledged.
    /// </summary>
    public IsoISODateTime? AcknowledgedStatusTimeStamp { get; init; } 
    /// <summary>
    /// Balance from which the securities are moving.
    /// </summary>
    public SecuritiesBalanceType11Choice_? BalanceFrom { get; init; } 
    /// <summary>
    /// Balance to which the securities are moving.
    /// </summary>
    public SecuritiesBalanceType11Choice_? BalanceTo { get; init; } 
    
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
        if (PoolIdentification is IsoRestrictedFINXMax16Text PoolIdentificationValue)
        {
            writer.WriteStartElement(null, "PoolId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(PoolIdentificationValue)); // data type RestrictedFINXMax16Text System.String
            writer.WriteEndElement();
        }
        if (AccountOwner is PartyIdentification103Choice_ AccountOwnerValue)
        {
            writer.WriteStartElement(null, "AcctOwnr", xmlNamespace );
            AccountOwnerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SfkpgAcct", xmlNamespace );
        SafekeepingAccount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "FinInstrmId", xmlNamespace );
        FinancialInstrumentIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SttlmQty", xmlNamespace );
        SettlementQuantity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (LotNumber is GenericIdentification39 LotNumberValue)
        {
            writer.WriteStartElement(null, "LotNb", xmlNamespace );
            LotNumberValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SttlmDt", xmlNamespace );
        SettlementDate.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AcknowledgedStatusTimeStamp is IsoISODateTime AcknowledgedStatusTimeStampValue)
        {
            writer.WriteStartElement(null, "AckdStsTmStmp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(AcknowledgedStatusTimeStampValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (BalanceFrom is SecuritiesBalanceType11Choice_ BalanceFromValue)
        {
            writer.WriteStartElement(null, "BalFr", xmlNamespace );
            BalanceFromValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BalanceTo is SecuritiesBalanceType11Choice_ BalanceToValue)
        {
            writer.WriteStartElement(null, "BalTo", xmlNamespace );
            BalanceToValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static IntraPositionDetails42 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
