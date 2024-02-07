﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentMeans1.  ISO2002 ID# _TCRjCAEcEeCQm6a_G2yO_w_-1888332883.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Means by which a payment will be or has been made for settlement purposes.
/// </summary>
public partial record PaymentMeans1
     : IIsoXmlSerilizable<PaymentMeans1>
{
    #nullable enable
    
    /// <summary>
    /// Type, or nature, of the payment, eg, express payment.
    /// </summary>
    public required PaymentTypeInformation19 PaymentType { get; init; } 
    /// <summary>
    /// Transfer method to be used for the transfer.
    /// </summary>
    public required PaymentMethod4Code PaymentMethodCode { get; init; } 
    /// <summary>
    /// Creditor financial account of the payee party for this payment means.
    /// </summary>
    public required CashAccount16 PayeeCreditorAccount { get; init; } 
    /// <summary>
    /// Creditor financial institution of the payee party specified for this payment means.
    /// </summary>
    public required BranchAndFinancialInstitutionIdentification4 PayeeFinancialInstitution { get; init; } 
    /// <summary>
    /// Debtor financial account of the payer party for this payment means.
    /// </summary>
    public CashAccount16? PayerDebtorAccount { get; init; } 
    /// <summary>
    /// Debtor financial institution of the payer party specified for this payment means.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification4? PayerFinancialInstitution { get; init; } 
    
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
        writer.WriteStartElement(null, "PmtTp", xmlNamespace );
        PaymentType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PmtMtdCd", xmlNamespace );
        writer.WriteValue(PaymentMethodCode.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PyeeCdtrAcct", xmlNamespace );
        PayeeCreditorAccount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PyeeFI", xmlNamespace );
        PayeeFinancialInstitution.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (PayerDebtorAccount is CashAccount16 PayerDebtorAccountValue)
        {
            writer.WriteStartElement(null, "PyerDbtrAcct", xmlNamespace );
            PayerDebtorAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PayerFinancialInstitution is BranchAndFinancialInstitutionIdentification4 PayerFinancialInstitutionValue)
        {
            writer.WriteStartElement(null, "PyerFI", xmlNamespace );
            PayerFinancialInstitutionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PaymentMeans1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
