"""Module providingFunction printing python version."""
import unittest


class TestStringMethods(unittest.TestCase):
    """Testing Class"""
    def test_upper(self):
        """Unit test 1"""
        self.assertEqual('foo'.upper(), 'FOO')

    def test_isupper(self):
        """Unit test 2"""
        self.assertTrue('FOO'.isupper())
        self.assertFalse('Foo'.isupper())

    def test_split(self):
        """unit test 3"""
        string_input = 'hello world'
        self.assertEqual(string_input.split(), ['hello', 'world'])
        # check that s.split fails when the separator is not a string
        with self.assertRaises(TypeError):
            string_input.split(2)


if __name__ == '__main__':
    unittest.main()
