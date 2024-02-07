﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StatementResolutionEntry4.  ISO2002 ID# _-RLPK249EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the statement entry for the resolution of the investigation.
/// </summary>
public partial record StatementResolutionEntry4
     : IIsoXmlSerilizable<StatementResolutionEntry4>
{
    #nullable enable
    
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    public OriginalGroupInformation29? OriginalGroupInformation { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the original statement.
    /// </summary>
    public IsoMax35Text? OriginalStatementIdentification { get; init; } 
    /// <summary>
    /// Universally unique identifier to provide an end-to-end reference of a payment transaction.
    /// </summary>
    public IsoUUIDv4Identifier? UETR { get; init; } 
    /// <summary>
    /// Unique reference, as assigned by the account servicing institution, to unambiguously identify the entry.
    /// </summary>
    public IsoMax35Text? AccountServicerReference { get; init; } 
    /// <summary>
    /// Corrected debit or credit amount, compared to the original entry where the amount is incorrect.||Usage: This amount may only be present if an incorrect statement entry has been reported.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? CorrectedAmount { get; init; } 
    /// <summary>
    /// Provides information on the charges included in the original entry amount.
    /// </summary>
    public Charges6? Charges { get; init; } 
    /// <summary>
    /// Underlying reason for the payment transaction.|Usage: Purpose is used by the end-customers, that is initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    public Purpose2Choice_? Purpose { get; init; } 
    
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
        if (OriginalGroupInformation is OriginalGroupInformation29 OriginalGroupInformationValue)
        {
            writer.WriteStartElement(null, "OrgnlGrpInf", xmlNamespace );
            OriginalGroupInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OriginalStatementIdentification is IsoMax35Text OriginalStatementIdentificationValue)
        {
            writer.WriteStartElement(null, "OrgnlStmtId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OriginalStatementIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (UETR is IsoUUIDv4Identifier UETRValue)
        {
            writer.WriteStartElement(null, "UETR", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoUUIDv4Identifier(UETRValue)); // data type UUIDv4Identifier System.String
            writer.WriteEndElement();
        }
        if (AccountServicerReference is IsoMax35Text AccountServicerReferenceValue)
        {
            writer.WriteStartElement(null, "AcctSvcrRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(AccountServicerReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (CorrectedAmount is IsoActiveOrHistoricCurrencyAndAmount CorrectedAmountValue)
        {
            writer.WriteStartElement(null, "CrrctdAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(CorrectedAmountValue)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (Charges is Charges6 ChargesValue)
        {
            writer.WriteStartElement(null, "Chrgs", xmlNamespace );
            ChargesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Purpose is Purpose2Choice_ PurposeValue)
        {
            writer.WriteStartElement(null, "Purp", xmlNamespace );
            PurposeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static StatementResolutionEntry4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
