"""Module providingFunction printing python version."""
import unittest


class TestStringMethods(unittest.TestCase):
    """Testing Class"""
    def test_upper(self):
        self.assertEqual('foo'.upper(), 'FOO')

    def test_isupper(self):
        self.assertTrue('FOO'.isupper())
        self.assertFalse('Foo'.isupper())

    def test_split(self):
        stringInput = 'hello world'
        self.assertEqual(stringInput.split(), ['hello', 'world'])
        # check that s.split fails when the separator is not a string
        with self.assertRaises(TypeError):
            stringInput.split(2)


if __name__ == '__main__':
    unittest.main()
