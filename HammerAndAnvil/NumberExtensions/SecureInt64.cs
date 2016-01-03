using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace System
{
    /// <summary>
    /// 초보적인 보안 64비트 정수형입니다.
    /// </summary>
    struct SecureInt64
    {
        const long key = 0x3a36b4bc2fe2a035;
        bool hashErr;
        long hash;
        long value;
        public SecureInt64(long value)
        {
            hashErr = false;
            long secureValue = value ^ key;
            this.hash = ComputeHash(secureValue);
            this.value = secureValue;
        }
        public long Value
        {
            get
            {
                HashCheck();

                if (hashErr)
                {
                    this.hash = ComputeHash(key);
                    this.value = key;

                    return value ^ key;
                }
                else
                {
                    return value ^ key;
                }
            }
            set
            {
                HashCheck();

                if (hashErr)
                {
                    this.hash = ComputeHash(key);
                    this.value = key;
                }
                else
                {
                    long secureValue = value ^ key;
                    this.hash = ComputeHash(secureValue);
                    this.value = secureValue;
                }
            }
        }
        bool HashCheck(long value)
        {
            return this.hash == ComputeHash(value);
        }
        void HashCheck()
        {
            this.hashErr = !HashCheck(this.value);
        }
        static long ComputeHash(long value)
        {
            value += ~(value << 15);
            value ^= (value >> 10);
            value += (value << 3);
            value ^= (value >> 6);
            value += ~(value << 11);
            value ^= (value >> 16);
            return value;
        }
        public static SecureInt64 operator +(SecureInt64 value)
        {
            value.Value = +value.Value;
            return value;
        }
        public static SecureInt64 operator -(SecureInt64 value)
        {
            value.Value = -value.Value;
            return value;
        }
        public static SecureInt64 operator ~(SecureInt64 value)
        {
            value.Value = ~value.Value;
            return value;
        }
        public static SecureInt64 operator ++(SecureInt64 value)
        {
            value.Value++;
            return value;
        }
        public static SecureInt64 operator --(SecureInt64 value)
        {
            value.Value--;
            return value;
        }
        public static SecureInt64 operator +(SecureInt64 left, long right)
        {
            left.Value += right;
            return left;
        }
        public static SecureInt64 operator +(SecureInt64 left, SecureInt64 right)
        {
            left.Value += right.Value;
            return left;
        }
        public static SecureInt64 operator -(SecureInt64 left, long right)
        {
            left.Value -= right;
            return left;
        }
        public static SecureInt64 operator -(SecureInt64 left, SecureInt64 right)
        {
            left.Value -= right.Value;
            return left;
        }
        public static SecureInt64 operator *(SecureInt64 left, long right)
        {
            left.Value *= right;
            return left;
        }
        public static SecureInt64 operator *(SecureInt64 left, SecureInt64 right)
        {
            left.Value *= right.Value;
            return left;
        }
        public static SecureInt64 operator /(SecureInt64 left, long right)
        {
            left.Value /= right;
            return left;
        }
        public static SecureInt64 operator /(SecureInt64 left, SecureInt64 right)
        {
            left.Value /= right.Value;
            return left;
        }
        public static SecureInt64 operator %(SecureInt64 left, long right)
        {
            left.Value %= right;
            return left;
        }
        public static SecureInt64 operator %(SecureInt64 left, SecureInt64 right)
        {
            left.Value %= right.Value;
            return left;
        }
        public static SecureInt64 operator &(SecureInt64 left, long right)
        {
            left.Value &= right;
            return left;
        }
        public static SecureInt64 operator &(SecureInt64 left, SecureInt64 right)
        {
            left.Value &= right.Value;
            return left;
        }
        public static SecureInt64 operator |(SecureInt64 left, long right)
        {
            left.Value |= right;
            return left;
        }
        public static SecureInt64 operator |(SecureInt64 left, SecureInt64 right)
        {
            left.Value |= right.Value;
            return left;
        }
        public static SecureInt64 operator ^(SecureInt64 left, long right)
        {
            left.Value ^= right;
            return left;
        }
        public static SecureInt64 operator ^(SecureInt64 left, SecureInt64 right)
        {
            left.Value ^= right.Value;
            return left;
        }
        public static SecureInt64 operator <<(SecureInt64 left, int right)
        {
            left.Value <<= right;
            return left;
        }
        public static SecureInt64 operator >>(SecureInt64 left, int right)
        {
            left.Value >>= right;
            return left;
        }
        public static bool operator ==(SecureInt64 left, long right)
        {
            return left.Value == right;
        }
        public static bool operator ==(SecureInt64 left, SecureInt64 right)
        {
            return left.Value == right.Value;
        }
        public static bool operator !=(SecureInt64 left, long right)
        {
            return left.Value != right;
        }
        public static bool operator !=(SecureInt64 left, SecureInt64 right)
        {
            return left.Value != right.Value;
        }
        public static bool operator <(SecureInt64 left, long right)
        {
            return left.Value < right;
        }
        public static bool operator <(SecureInt64 left, SecureInt64 right)
        {
            return left.Value < right.Value;
        }
        public static bool operator >(SecureInt64 left, long right)
        {
            return left.Value > right;
        }
        public static bool operator >(SecureInt64 left, SecureInt64 right)
        {
            return left.Value > right.Value;
        }
        public static bool operator <=(SecureInt64 left, long right)
        {
            return left.Value <= right;
        }
        public static bool operator <=(SecureInt64 left, SecureInt64 right)
        {
            return left.Value <= right.Value;
        }
        public static bool operator >=(SecureInt64 left, long right)
        {
            return left.Value >= right;
        }
        public static bool operator >=(SecureInt64 left, SecureInt64 right)
        {
            return left.Value >= right.Value;
        }
        public static implicit operator SecureInt64(long value)
        {
            return new SecureInt64(value);
        }
        public static implicit operator long (SecureInt64 value)
        {
            return value.Value;
        }
    }
}
