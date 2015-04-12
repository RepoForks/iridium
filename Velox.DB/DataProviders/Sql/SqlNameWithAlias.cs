#region License
//=============================================================================
// Velox.DB - Portable .NET ORM 
//
// Copyright (c) 2015 Philippe Leybaert
//
// Permission is hereby granted, free of charge, to any person obtaining a copy 
// of this software and associated documentation files (the "Software"), to deal 
// in the Software without restriction, including without limitation the rights 
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell 
// copies of the Software, and to permit persons to whom the Software is 
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in 
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING 
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
//=============================================================================
#endregion

namespace Velox.DB.Sql
{
    public class SqlExpressionWithAlias
    {
        public SqlExpressionWithAlias(string expression, string alias = null)
        {
            Expression = expression;
            Alias = alias;
        }

        public string Expression;
        public string Alias;

        public virtual bool ShouldQuote { get { return false; } }
    }

    public class SqlColumnNameWithAlias : SqlExpressionWithAlias
    {
        public SqlColumnNameWithAlias(string name, string alias = null) : base(name,alias)
        {
        }

        //public string ColumnName { get {  return Expression; } }

        public override bool ShouldQuote { get { return true; } }
    }

    public class SqlTableNameWithAlias : SqlExpressionWithAlias
    {
        public SqlTableNameWithAlias(string name, string alias = null) : base(name, alias)
        {
        }

        public string TableName { get { return Expression; } }

        public override bool ShouldQuote { get { return true; } }
    }

}