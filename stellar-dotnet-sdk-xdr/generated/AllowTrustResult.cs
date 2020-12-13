﻿// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
namespace stellar_dotnet_sdk.xdr
{

    // === xdr source ============================================================
    //  union AllowTrustResult switch (AllowTrustResultCode code)
    //  {
    //  case ALLOW_TRUST_SUCCESS:
    //      void;
    //  default:
    //      void;
    //  };
    //  ===========================================================================
    public class AllowTrustResult
    {
        public AllowTrustResult() { }
        public AllowTrustResultCode Discriminant { get; set; } = new AllowTrustResultCode();
        public static void Encode(XdrDataOutputStream stream, AllowTrustResult encodedAllowTrustResult)
        {
            stream.WriteInt((int)encodedAllowTrustResult.Discriminant.InnerValue);
            switch (encodedAllowTrustResult.Discriminant.InnerValue)
            {
                case AllowTrustResultCode.AllowTrustResultCodeEnum.ALLOW_TRUST_SUCCESS:
                    break;
                default:
                    break;
            }
        }
        public static AllowTrustResult Decode(XdrDataInputStream stream)
        {
            AllowTrustResult decodedAllowTrustResult = new AllowTrustResult();
            AllowTrustResultCode discriminant = AllowTrustResultCode.Decode(stream);
            decodedAllowTrustResult.Discriminant = discriminant;
            switch (decodedAllowTrustResult.Discriminant.InnerValue)
            {
                case AllowTrustResultCode.AllowTrustResultCodeEnum.ALLOW_TRUST_SUCCESS:
                    break;
                default:
                    break;
            }
            return decodedAllowTrustResult;
        }
    }
}