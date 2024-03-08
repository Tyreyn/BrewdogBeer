namespace BrewdogBeer.Helpers
{
    /// <summary>
    /// The static class for operations on variables.
    /// </summary>
    public static class ValueOperations
    {
        /// <summary>
        /// Check if variable is double.
        /// </summary>
        /// <typeparam name="T">
        /// Generic parameter.
        /// </typeparam>
        /// <param name="variableValue">
        /// The variable to check value.
        /// </param>
        /// <returns>
        /// True, if variable is double.
        /// </returns>
        public static bool IsDouble<T>(T variableValue)
        {
            return variableValue is double;
        }

        /// <summary>
        /// Check if variable is null.
        /// </summary>
        /// <typeparam name="T">
        /// Generic parameter.
        /// </typeparam>
        /// <param name="variableValue">
        /// The variable to check value.
        /// </param>
        /// <returns>
        /// True, if variable is null.
        /// </returns>
        public static bool IsNull<T>(T variableValue)
        {
            return variableValue == null;
        }

        /// <summary>
        /// Check if variable is empty.
        /// </summary>
        /// <param name="variableValue">
        /// The variable to check value.
        /// </param>
        /// <returns>
        /// True, if variable is Empty.
        /// </returns>
        public static bool IsEmpty(string variableValue)
        {
            return variableValue == string.Empty;
        }
    }
}
