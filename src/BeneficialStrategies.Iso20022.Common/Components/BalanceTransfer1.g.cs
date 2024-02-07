﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BalanceTransfer1.  ISO2002 ID# _5yEaVA_QEeejZrQVdmNFGg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that enables any payments made in connection with the fulfilment of an account switch to be reconciled by the relevant account servicer with the associated request.
/// </summary>
public partial record BalanceTransfer1
     : IIsoXmlSerilizable<BalanceTransfer1>
{
    #nullable enable
    
    /// <summary>
    /// Reference that enables the creditor to reconcile a payment received through a different payment channel with the payment request.
    /// </summary>
    public BalanceTransferReference1? BalanceTransferReference { get; init; } 
    /// <summary>
    /// Contains details of the clearance and settlement method chosen to make the appropriate payment from account servicer to account servicer in order to transfer the positive or negative closing balance of the old account to the new account.
    /// </summary>
    public SettlementMethod1Choice_? BalanceTransferMethod { get; init; } 
    /// <summary>
    /// Maximum value that the new account servicer will pay to the old account servicer when the closing balance on the old account is negative.
    /// </summary>
    public BalanceTransferFundingLimit1? BalanceTransferFundingLimit { get; init; } 
    
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
        if (BalanceTransferReference is BalanceTransferReference1 BalanceTransferReferenceValue)
        {
            writer.WriteStartElement(null, "BalTrfRef", xmlNamespace );
            BalanceTransferReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BalanceTransferMethod is SettlementMethod1Choice_ BalanceTransferMethodValue)
        {
            writer.WriteStartElement(null, "BalTrfMtd", xmlNamespace );
            BalanceTransferMethodValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BalanceTransferFundingLimit is BalanceTransferFundingLimit1 BalanceTransferFundingLimitValue)
        {
            writer.WriteStartElement(null, "BalTrfFndgLmt", xmlNamespace );
            BalanceTransferFundingLimitValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static BalanceTransfer1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
