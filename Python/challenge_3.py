"""
Create simple class that converts roman numerals to integers and vice versa.

"IV" = 4
9 = "IX"
etc.

Refer to the unit tests to grasp the idea of this task.
Feel free to add as many unit tests as you want.
No external dependencies!

P.S.: you cant leverage all benefits of classes. ;) 
"""
import unittest


class Convertor:
    """
    Base class that converts roman numerals to integers and vice versa.
    """

    @staticmethod
    def convert_to_roman(integer: int) -> str:
        """
        Integers to roman numerals
        """
        return ""

    @staticmethod
    def convert_to_integers(roman: str) -> int:
        """
        Roman numerals to integers
        """
        return 0


class ConvertorTestCase(unittest.TestCase):
    """
    Unit tests
    """

    def __init__(self, methodName: str = "runTest") -> None:
        """
        Superconstructor
        """
        self.convertor = Convertor()
        self.test_cases = [
            {
                "integer": 1995,
                "roman": "MCMXCV",
            },
            {
                "integer": 2023,
                "roman": "MMXXIII",
            },
        ]
        super().__init__(methodName)

    def test_convert_to_roman(self):
        """
        Table-driven tests
        """
        for case in self.testcases:
            res = self.convertor.convert_to_roman(case["integer"])
            self.assertEqual(
                res,
                case["roman"],
                f'\nfailed test case "{case["integer"]}": expected "{case["roman"]}", but got "{res}".',
            )

    def test_convert_to_integers(self):
        """
        Table-driven tests
        """
        for case in self.testcases:
            res = self.convertor.convert_to_integers(case["roman"])
            self.assertEqual(
                res,
                case["integer"],
                f'\nfailed test case "{case["roman"]}": expected "{case["integer"]}", but got "{res}".',
            )


if __name__ == "__main__":
    unittest.main()
