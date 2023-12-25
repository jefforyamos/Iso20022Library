﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransactionReasonCode.  ISO2002 ID# _YsS_xdp-Ed-ak6NoX_4Aeg_-819075130.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for a transaction to be rejected, returned or reversed by an instructed agent or somebody acting on behalf of an instructed agent.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YsS_xdp-Ed-ak6NoX_4Aeg_-819075130")]
[Description(@"Specifies the reason for a transaction to be rejected, returned or reversed by an instructed agent or somebody acting on behalf of an instructed agent.")]
public enum TransactionReasonCode
{
    /// <summary>
    /// Format of the account number specified is not correct.
    /// </summary>
    [EnumMember(Value = "AC01")]
    [IsoId("_YsS_xtp-Ed-ak6NoX_4Aeg_-371166097")]
    [Description(@"Format of the account number specified is not correct.")]
    AC01,
    
    /// <summary>
    /// Format of the account number specified is non-numeric.
    /// </summary>
    [EnumMember(Value = "AC02")]
    [IsoId("_YsS_x9p-Ed-ak6NoX_4Aeg_-371166037")]
    [Description(@"Format of the account number specified is non-numeric.")]
    AC02,
    
    /// <summary>
    /// Format of the account number specified is not valid for local Sort/National Clearing Code.
    /// </summary>
    [EnumMember(Value = "AC03")]
    [IsoId("_YsS_yNp-Ed-ak6NoX_4Aeg_-371166002")]
    [Description(@"Format of the account number specified is not valid for local Sort/National Clearing Code.")]
    AC03,
    
    /// <summary>
    /// Account number specified has been closed on the Receiver's books.
    /// </summary>
    [EnumMember(Value = "AC04")]
    [IsoId("_YsS_ydp-Ed-ak6NoX_4Aeg_-371165924")]
    [Description(@"Account number specified has been closed on the Receiver's books.")]
    AC04,
    
    /// <summary>
    /// Account number specified is not a valid account at the Final Agent.
    /// </summary>
    [EnumMember(Value = "AC05")]
    [IsoId("_YscJsNp-Ed-ak6NoX_4Aeg_-371165882")]
    [Description(@"Account number specified is not a valid account at the Final Agent.")]
    AC05,
    
    /// <summary>
    /// Account specified is blocked, prohibiting posting of transactions against it.
    /// </summary>
    [EnumMember(Value = "AC06")]
    [IsoId("_YscJsdp-Ed-ak6NoX_4Aeg_-371165611")]
    [Description(@"Account specified is blocked, prohibiting posting of transactions against it.")]
    AC06,
    
    /// <summary>
    /// Specified message amount is equal to zero.
    /// </summary>
    [EnumMember(Value = "AM01")]
    [IsoId("_YscJstp-Ed-ak6NoX_4Aeg_-371165509")]
    [Description(@"Specified message amount is equal to zero.")]
    AM01,
    
    /// <summary>
    /// Specified transaction/message amount is greater than allowed maximum.
    /// </summary>
    [EnumMember(Value = "AM02")]
    [IsoId("_YscJs9p-Ed-ak6NoX_4Aeg_-371165183")]
    [Description(@"Specified transaction/message amount is greater than allowed maximum.")]
    AM02,
    
    /// <summary>
    /// Specified message amount is in an non processable currency outside of existing agreement.
    /// </summary>
    [EnumMember(Value = "AM03")]
    [IsoId("_YscJtNp-Ed-ak6NoX_4Aeg_-371165123")]
    [Description(@"Specified message amount is in an non processable currency outside of existing agreement.")]
    AM03,
    
    /// <summary>
    /// Amount of funds available to cover specified message amount is insufficient.
    /// </summary>
    [EnumMember(Value = "AM04")]
    [IsoId("_YscJtdp-Ed-ak6NoX_4Aeg_-371165071")]
    [Description(@"Amount of funds available to cover specified message amount is insufficient.")]
    AM04,
    
    /// <summary>
    /// This message appears to have been duplicated.
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_YscJttp-Ed-ak6NoX_4Aeg_-371165011")]
    [Description(@"This message appears to have been duplicated.")]
    AM05,
    
    /// <summary>
    /// Specified transaction amount is less than agreed minimum.
    /// </summary>
    [EnumMember(Value = "AM06")]
    [IsoId("_YscJt9p-Ed-ak6NoX_4Aeg_-371164951")]
    [Description(@"Specified transaction amount is less than agreed minimum.")]
    AM06,
    
    /// <summary>
    /// Amount specified in message has been blocked by regulatory authorities.
    /// </summary>
    [EnumMember(Value = "AM07")]
    [IsoId("_YscJuNp-Ed-ak6NoX_4Aeg_-371164656")]
    [Description(@"Amount specified in message has been blocked by regulatory authorities.")]
    AM07,
    
    /// <summary>
    /// Specified charges amount is not as agreed between sender and receiver.
    /// </summary>
    [EnumMember(Value = "AM08")]
    [IsoId("_YscJudp-Ed-ak6NoX_4Aeg_-371164596")]
    [Description(@"Specified charges amount is not as agreed between sender and receiver.")]
    AM08,
    
    /// <summary>
    /// Identification of end customer is not consistent with associated account number. (formerly CreditorConsistency).
    /// </summary>
    [EnumMember(Value = "BE01")]
    [IsoId("_Ysl6sNp-Ed-ak6NoX_4Aeg_-371164544")]
    [Description(@"Identification of end customer is not consistent with associated account number. (formerly CreditorConsistency).")]
    BE01,
    
    /// <summary>
    /// Creditor specified is not known at associated Sort/National Clearing code.
    /// </summary>
    [EnumMember(Value = "BE02")]
    [IsoId("_Ysl6sdp-Ed-ak6NoX_4Aeg_-370244477")]
    [Description(@"Creditor specified is not known at associated Sort/National Clearing code.")]
    BE02,
    
    /// <summary>
    /// Creditor specified no longer exists in the books.
    /// </summary>
    [EnumMember(Value = "BE03")]
    [IsoId("_Ysl6stp-Ed-ak6NoX_4Aeg_-370244322")]
    [Description(@"Creditor specified no longer exists in the books.")]
    BE03,
    
    /// <summary>
    /// Specification of creditor's address, which is required for payment, is missing/not correct (formerly IncorrectCreditorAddress).
    /// </summary>
    [EnumMember(Value = "BE04")]
    [IsoId("_Ysl6s9p-Ed-ak6NoX_4Aeg_-370244020")]
    [Description(@"Specification of creditor's address, which is required for payment, is missing/not correct (formerly IncorrectCreditorAddress).")]
    BE04,
    
    /// <summary>
    /// Party who initiated the message is not recognised by the end customer.
    /// </summary>
    [EnumMember(Value = "BE05")]
    [IsoId("_Ysl6tNp-Ed-ak6NoX_4Aeg_-370243925")]
    [Description(@"Party who initiated the message is not recognised by the end customer.")]
    BE05,
    
    /// <summary>
    /// Transaction forbidden on this type of account (formerly NoAgreement).
    /// </summary>
    [EnumMember(Value = "AG01")]
    [IsoId("_Ysl6tdp-Ed-ak6NoX_4Aeg_-370243865")]
    [Description(@"Transaction forbidden on this type of account (formerly NoAgreement).")]
    AG01,
    
    /// <summary>
    /// Bank Operation code specified in the message is not valid for receiver.
    /// </summary>
    [EnumMember(Value = "AG02")]
    [IsoId("_Ysl6ttp-Ed-ak6NoX_4Aeg_-370243522")]
    [Description(@"Bank Operation code specified in the message is not valid for receiver.")]
    AG02,
    
    /// <summary>
    /// Invalid date (eg, wrong settlement date).
    /// </summary>
    [EnumMember(Value = "DT01")]
    [IsoId("_Ysl6t9p-Ed-ak6NoX_4Aeg_-370243427")]
    [Description(@"Invalid date (eg, wrong settlement date).")]
    DT01,
    
    /// <summary>
    /// Reason has not been specified due to sensitivities.
    /// </summary>
    [EnumMember(Value = "MS01")]
    [IsoId("_Ysl6uNp-Ed-ak6NoX_4Aeg_-370243331")]
    [Description(@"Reason has not been specified due to sensitivities.")]
    MS01,
    
    /// <summary>
    /// Unknown account with institution.
    /// </summary>
    [EnumMember(Value = "PY01")]
    [IsoId("_Ysl6udp-Ed-ak6NoX_4Aeg_-370243012")]
    [Description(@"Unknown account with institution.")]
    PY01,
    
    /// <summary>
    /// Transaction reference is not unique within the message.
    /// </summary>
    [EnumMember(Value = "RF01")]
    [IsoId("_YsvrsNp-Ed-ak6NoX_4Aeg_-370242959")]
    [Description(@"Transaction reference is not unique within the message.")]
    RF01,
    
    /// <summary>
    /// Bank identifier code specified in the message has an incorrect format (formerly IncorrectFormatForRoutingCode).
    /// </summary>
    [EnumMember(Value = "RC01")]
    [IsoId("_Ysvrsdp-Ed-ak6NoX_4Aeg_-370242609")]
    [Description(@"Bank identifier code specified in the message has an incorrect format (formerly IncorrectFormatForRoutingCode).")]
    RC01,
    
    /// <summary>
    /// Routing code specified in the transaction/message is not numeric.
    /// </summary>
    [EnumMember(Value = "RC02")]
    [IsoId("_Ysvrstp-Ed-ak6NoX_4Aeg_-370242531")]
    [Description(@"Routing code specified in the transaction/message is not numeric.")]
    RC02,
    
    /// <summary>
    /// Routing code specified in the transaction/message is not valid for local clearing.
    /// </summary>
    [EnumMember(Value = "RC03")]
    [IsoId("_Ysvrs9p-Ed-ak6NoX_4Aeg_-370242436")]
    [Description(@"Routing code specified in the transaction/message is not valid for local clearing.")]
    RC03,
    
    /// <summary>
    /// Routing code specified in the transaction/message refers to a closed branch.
    /// </summary>
    [EnumMember(Value = "RC04")]
    [IsoId("_YsvrtNp-Ed-ak6NoX_4Aeg_-370242341")]
    [Description(@"Routing code specified in the transaction/message refers to a closed branch.")]
    RC04,
    
    /// <summary>
    /// Associated message was received after agreed processing cut-off time.
    /// </summary>
    [EnumMember(Value = "TM01")]
    [IsoId("_Ysvrtdp-Ed-ak6NoX_4Aeg_-370242047")]
    [Description(@"Associated message was received after agreed processing cut-off time.")]
    TM01,
    
    /// <summary>
    /// Correspondent bank not possible.
    /// </summary>
    [EnumMember(Value = "ED01")]
    [IsoId("_Ysvrttp-Ed-ak6NoX_4Aeg_-370241927")]
    [Description(@"Correspondent bank not possible.")]
    ED01,
    
    /// <summary>
    /// Transaction reason non reportable.
    /// </summary>
    [EnumMember(Value = "ED02")]
    [IsoId("_Ysvrt9p-Ed-ak6NoX_4Aeg_-370241584")]
    [Description(@"Transaction reason non reportable.")]
    ED02,
    
    /// <summary>
    /// Balance of payments complementary info is requested.
    /// </summary>
    [EnumMember(Value = "ED03")]
    [IsoId("_YsvruNp-Ed-ak6NoX_4Aeg_-370241489")]
    [Description(@"Balance of payments complementary info is requested.")]
    ED03,
    
    /// <summary>
    /// Charge details not correct.
    /// </summary>
    [EnumMember(Value = "ED04")]
    [IsoId("_Ysvrudp-Ed-ak6NoX_4Aeg_-370241369")]
    [Description(@"Charge details not correct.")]
    ED04,
    
    /// <summary>
    /// Reason has not been specified by agent.
    /// </summary>
    [EnumMember(Value = "MS03")]
    [IsoId("_Ysvrutp-Ed-ak6NoX_4Aeg_1015961068")]
    [Description(@"Reason has not been specified by agent.")]
    MS03,
    
    /// <summary>
    /// Reason has not been specified by end customer.
    /// </summary>
    [EnumMember(Value = "MS02")]
    [IsoId("_Ys41oNp-Ed-ak6NoX_4Aeg_1030740222")]
    [Description(@"Reason has not been specified by end customer.")]
    MS02,
    
    /// <summary>
    /// End customer specified is not known at associated Sort/National Bank Code or does no longer exist in the books.
    /// </summary>
    [EnumMember(Value = "BE06")]
    [IsoId("_Ys41odp-Ed-ak6NoX_4Aeg_1473105324")]
    [Description(@"End customer specified is not known at associated Sort/National Bank Code or does no longer exist in the books.")]
    BE06,
    
    /// <summary>
    /// Specification of debtor's address, which is required for payment, is missing/not correct.
    /// </summary>
    [EnumMember(Value = "BE07")]
    [IsoId("_Ys41otp-Ed-ak6NoX_4Aeg_1904390558")]
    [Description(@"Specification of debtor's address, which is required for payment, is missing/not correct.")]
    BE07,
    
    /// <summary>
    /// Amount received is not the amount agreed or expected.
    /// </summary>
    [EnumMember(Value = "AM09")]
    [IsoId("_Ys41o9p-Ed-ak6NoX_4Aeg_-1889107065")]
    [Description(@"Amount received is not the amount agreed or expected.")]
    AM09,
    
    /// <summary>
    /// Sum of instructed amounts does not equal the control sum.
    /// </summary>
    [EnumMember(Value = "AM10")]
    [IsoId("_Ys41pNp-Ed-ak6NoX_4Aeg_-1564026693")]
    [Description(@"Sum of instructed amounts does not equal the control sum.")]
    AM10,
    
    /// <summary>
    /// Mandate is cancelled or invalid.
    /// </summary>
    [EnumMember(Value = "MD01")]
    [IsoId("_Ys41pdp-Ed-ak6NoX_4Aeg_-1003449105")]
    [Description(@"Mandate is cancelled or invalid.")]
    MD01,
    
    /// <summary>
    /// Mandate related information data required by the scheme is missing.
    /// </summary>
    [EnumMember(Value = "MD02")]
    [IsoId("_Ys41ptp-Ed-ak6NoX_4Aeg_-900939252")]
    [Description(@"Mandate related information data required by the scheme is missing.")]
    MD02,
    
    /// <summary>
    /// File format incomplete or invalid.
    /// </summary>
    [EnumMember(Value = "MD03")]
    [IsoId("_Ys41p9p-Ed-ak6NoX_4Aeg_-604488852")]
    [Description(@"File format incomplete or invalid.")]
    MD03,
    
    /// <summary>
    /// File format incorrect in terms of grouping indicator.
    /// </summary>
    [EnumMember(Value = "MD04")]
    [IsoId("_Ys41qNp-Ed-ak6NoX_4Aeg_-286797660")]
    [Description(@"File format incorrect in terms of grouping indicator.")]
    MD04,
    
    /// <summary>
    /// Return of funds requested by end customer.
    /// </summary>
    [EnumMember(Value = "MD06")]
    [IsoId("_YtCmoNp-Ed-ak6NoX_4Aeg_-83623586")]
    [Description(@"Return of funds requested by end customer.")]
    MD06,
    
    /// <summary>
    /// End customer is deceased.
    /// </summary>
    [EnumMember(Value = "MD07")]
    [IsoId("_YtCmodp-Ed-ak6NoX_4Aeg_197126350")]
    [Description(@"End customer is deceased.")]
    MD07,
    
    /// <summary>
    /// Creditor or creditor's agent should not have collected the direct debit.
    /// </summary>
    [EnumMember(Value = "MD05")]
    [IsoId("_YtCmotp-Ed-ak6NoX_4Aeg_338428408")]
    [Description(@"Creditor or creditor's agent should not have collected the direct debit.")]
    MD05,
    
    /// <summary>
    /// Name provided is not valid.
    /// </summary>
    [EnumMember(Value = "AC07")]
    [IsoId("_YtCmo9p-Ed-ak6NoX_4Aeg_-275055644")]
    [Description(@"Name provided is not valid.")]
    AC07,
    
    /// <summary>
    /// Settlement of the transaction has failed.
    /// </summary>
    [EnumMember(Value = "ED05")]
    [IsoId("_YtCmpNp-Ed-ak6NoX_4Aeg_-1585165125")]
    [Description(@"Settlement of the transaction has failed.")]
    ED05,
    
    /// <summary>
    /// Reason is provided as narrative information in the additional reason information.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_YtCmpdp-Ed-ak6NoX_4Aeg_-1585164368")]
    [Description(@"Reason is provided as narrative information in the additional reason information.")]
    NARR,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransactionReasonCodeMetadataExtensions
{
    private static readonly TransactionReasonCodeDropdownSource _dropdownSource = new TransactionReasonCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransactionReasonCodeDropdownRow GetMetadata(this TransactionReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


