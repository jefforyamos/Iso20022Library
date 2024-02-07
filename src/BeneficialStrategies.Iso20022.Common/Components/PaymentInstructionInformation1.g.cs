﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentInstructionInformation1.  ISO2002 ID# _PhfdE9p-Ed-ak6NoX_4Aeg_-259128313.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics that apply to the debit side of the payment transactions included in the credit transfer transaction initiation.
/// </summary>
public partial record PaymentInstructionInformation1
     : IIsoXmlSerilizable<PaymentInstructionInformation1>
{
    #nullable enable
    
    /// <summary>
    /// Reference assigned by a sending party to unambiguously identify the payment information block within the message.
    /// </summary>
    public IsoMax35Text? PaymentInformationIdentification { get; init; } 
    /// <summary>
    /// Specifies the means of payment that will be used to move the amount of money.
    /// </summary>
    public required PaymentMethod3Code PaymentMethod { get; init; } 
    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    public PaymentTypeInformation1? PaymentTypeInformation { get; init; } 
    /// <summary>
    /// Date at which the initiating party requests the clearing agent to process the payment. If payment by cheque, the date when the cheque must be generated by the bank.||Usage: This is the date on which the debtor's account(s) is (are) to be debited.
    /// </summary>
    public required IsoISODate RequestedExecutionDate { get; init; } 
    /// <summary>
    /// Date used for the correction of the value date of a cash pool movement that has been posted with a different value date.
    /// </summary>
    public IsoISODate? PoolingAdjustmentDate { get; init; } 
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    public required PartyIdentification8 Debtor { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    public required CashAccount7 DebtorAccount { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    public required BranchAndFinancialInstitutionIdentification3 DebtorAgent { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    public CashAccount7? DebtorAgentAccount { get; init; } 
    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    public PartyIdentification8? UltimateDebtor { get; init; } 
    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    public ChargeBearerType1Code? ChargeBearer { get; init; } 
    /// <summary>
    /// Account used to process charges associated with a transaction.||Usage: charges account should be used when charges have to be booked to an account different from the account identified in debtor's account.
    /// </summary>
    public CashAccount7? ChargesAccount { get; init; } 
    /// <summary>
    /// Agent that services a charges account. ||Usage: charges account agent should only be used when the charges account agent is different from the debtor agent.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification3? ChargesAccountAgent { get; init; } 
    /// <summary>
    /// Set of elements providing information specific to the individual transaction(s) included in the message.
    /// </summary>
    public CreditTransferTransactionInformation1? CreditTransferTransactionInformation { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _PhonB9p-Ed-ak6NoX_4Aeg_-259127416
    
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
        if (PaymentInformationIdentification is IsoMax35Text PaymentInformationIdentificationValue)
        {
            writer.WriteStartElement(null, "PmtInfId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(PaymentInformationIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "PmtMtd", xmlNamespace );
        writer.WriteValue(PaymentMethod.ToString()); // Enum value
        writer.WriteEndElement();
        if (PaymentTypeInformation is PaymentTypeInformation1 PaymentTypeInformationValue)
        {
            writer.WriteStartElement(null, "PmtTpInf", xmlNamespace );
            PaymentTypeInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "ReqdExctnDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(RequestedExecutionDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        if (PoolingAdjustmentDate is IsoISODate PoolingAdjustmentDateValue)
        {
            writer.WriteStartElement(null, "PoolgAdjstmntDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(PoolingAdjustmentDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Dbtr", xmlNamespace );
        Debtor.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "DbtrAcct", xmlNamespace );
        DebtorAccount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "DbtrAgt", xmlNamespace );
        DebtorAgent.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (DebtorAgentAccount is CashAccount7 DebtorAgentAccountValue)
        {
            writer.WriteStartElement(null, "DbtrAgtAcct", xmlNamespace );
            DebtorAgentAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UltimateDebtor is PartyIdentification8 UltimateDebtorValue)
        {
            writer.WriteStartElement(null, "UltmtDbtr", xmlNamespace );
            UltimateDebtorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ChargeBearer is ChargeBearerType1Code ChargeBearerValue)
        {
            writer.WriteStartElement(null, "ChrgBr", xmlNamespace );
            writer.WriteValue(ChargeBearerValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ChargesAccount is CashAccount7 ChargesAccountValue)
        {
            writer.WriteStartElement(null, "ChrgsAcct", xmlNamespace );
            ChargesAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ChargesAccountAgent is BranchAndFinancialInstitutionIdentification3 ChargesAccountAgentValue)
        {
            writer.WriteStartElement(null, "ChrgsAcctAgt", xmlNamespace );
            ChargesAccountAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        // Not sure how to serialize CreditTransferTransactionInformation, multiplicity Unknown
    }
    public static PaymentInstructionInformation1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
