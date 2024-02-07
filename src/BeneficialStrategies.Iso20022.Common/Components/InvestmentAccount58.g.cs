﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvestmentAccount58.  ISO2002 ID# _z8ujsTbsEead9bDRE_1DAQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
/// </summary>
public partial record InvestmentAccount58
     : IIsoXmlSerilizable<InvestmentAccount58>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public required IsoMax35Text AccountIdentification { get; init; } 
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    public IsoMax35Text? AccountName { get; init; } 
    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to reconciled individually.
    /// </summary>
    public IsoMax35Text? AccountDesignation { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public PartyIdentification113? OwnerIdentification { get; init; } 
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    public PartyIdentification113? AccountServicer { get; init; } 
    /// <summary>
    /// Counterparties eligibility as defined by article 24 of the EU MiFID Directive applicable to transactions executed by investment firms for eligible counterparties.
    /// </summary>
    public OrderOriginatorEligibility1Code? OrderOriginatorEligibility { get; init; } 
    /// <summary>
    /// Sub-account of the master or omnibus account.
    /// </summary>
    public SubAccount6? SubAccountDetails { get; init; } 
    
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
        writer.WriteStartElement(null, "AcctId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(AccountIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (AccountName is IsoMax35Text AccountNameValue)
        {
            writer.WriteStartElement(null, "AcctNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(AccountNameValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (AccountDesignation is IsoMax35Text AccountDesignationValue)
        {
            writer.WriteStartElement(null, "AcctDsgnt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(AccountDesignationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (OwnerIdentification is PartyIdentification113 OwnerIdentificationValue)
        {
            writer.WriteStartElement(null, "OwnrId", xmlNamespace );
            OwnerIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AccountServicer is PartyIdentification113 AccountServicerValue)
        {
            writer.WriteStartElement(null, "AcctSvcr", xmlNamespace );
            AccountServicerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OrderOriginatorEligibility is OrderOriginatorEligibility1Code OrderOriginatorEligibilityValue)
        {
            writer.WriteStartElement(null, "OrdrOrgtrElgblty", xmlNamespace );
            writer.WriteValue(OrderOriginatorEligibilityValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (SubAccountDetails is SubAccount6 SubAccountDetailsValue)
        {
            writer.WriteStartElement(null, "SubAcctDtls", xmlNamespace );
            SubAccountDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static InvestmentAccount58 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
